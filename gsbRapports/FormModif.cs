using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FormModif : Form
    {
        private gsbrapports2016Entities gsbData;

        //
        // ------------------------------------- Constructeur -------------------------------------
        // 

        public FormModif(gsbrapports2016Entities gsb)
        {
            InitializeComponent();
            this.gsbData = gsb;

            // initialisation des bindingsSource

            this.bdgVisiteur.DataSource = gsb.visiteurs.ToList();

            // initialisation du valuemember a null la combobox retournera ainsi un objet

            cbxVisiteur.ValueMember = null;

            // configuration du dataGridview gridRapport afin qu'il ne genere pas de colonnes automatiquement

            this.gridRapport.AutoGenerateColumns = false;
        }

  //
  // ------------------------------------- MENU -------------------------------------
  //

        private void FormModif_Load(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FormAjout f = new FormAjout(this.gsbData);
            f.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FormCherche f = new FormCherche(this.gsbData);
            f.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FormModif f = new FormModif(this.gsbData);
            f.Show();
        }

        //
        // ------------------------------------- BOUTONS -------------------------------------
        //

          // au click du bouton afficher, une liste de rapport est crée avec comme filtre le visiteur 
          // ainsi que la date du rapport cette liste sert ensuite a alimenter le datagridview gridRapport
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            visiteur visit = (visiteur)cbxVisiteur.SelectedValue;
            DateTime date = Convert.ToDateTime(datebox.Text);
            var lesRapports = (from r in this.gsbData.rapports
                                           join v in this.gsbData.visiteurs on r.idVisiteur equals v.id
                                           where v.id == visit.id && r.date == date
                                           select r).ToList();

            this.gridRapport.DataSource = lesRapports;
        }


          // au click du bouton de la ligne, l'id du rapport concerné par la ligne du datagridview
          // est envoyé a un nouveau formulaire permettant la modification du rapport en question
        private void gridRapport_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idR = Convert.ToInt32(gridRapport.Rows.SharedRow(e.RowIndex).Cells[0].Value.ToString());
            FormEdition fe = new FormEdition(gsbData, idR);
            fe.Show();

        }
    }
}
