using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


namespace gsbRapports
{
    public partial class FormCherche : Form
    {
        private gsbrapports2016Entities gsbData;

        //
        // ------------------------------------- Constructeur -------------------------------------
        //

        public FormCherche(gsbrapports2016Entities gsb)
        {
            InitializeComponent();
            this.gsbData = gsb;

            // initialisation des bindingsSource

            this.bdgVisiteur.DataSource = gsb.visiteurs.ToList();
            this.bdgMedecin.DataSource = gsb.medecins.ToList();

            // initialisation des valuemember a null
            // les combobox retourneront ainsi des objets
     
            cmbxMedecin.ValueMember = null;
            cmbxVisiteur.ValueMember = null;
        }

        private void FormCherche_Load(object sender, EventArgs e)
        {

        }

        //
        // ------------------------------------- MENU -------------------------------------
        //

        private void ajouterToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FormAjout f = new FormAjout(gsbData);
            f.Show();
        }

        private void rechercherToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FormCherche f = new FormCherche(gsbData);
            f.Show();
        }

        private void modifierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FormModif f = new FormModif(gsbData);
            f.Show();
        }

        //
        // ------------------------------------- CHECKBOXES -------------------------------------
        //

        private void chbxVisiteur_CheckedChanged(object sender, EventArgs e)
        {
            // si la checkbox est cochée, la combobox visiteur devient visible
            // si la checkbox est decochée, la combobox visiteur devient invisible
            if (chbxVisiteur.Checked)
            {
                cmbxVisiteur.Visible = true;
            }
            else
            {
                cmbxVisiteur.Visible = false;
            }
        }

        private void chbxMedecin_CheckedChanged(object sender, EventArgs e)
        {
            // si la checkbox est cochée, la combobox medecin devient visible
            // si la checkbox est decochée, la combobox medecin devient invisible
            if (chbxMedecin.Checked)
            {
                cmbxMedecin.Visible = true;
            }
            else
            {
                cmbxMedecin.Visible = false;
            }
        }

        private void chbxDate_CheckedChanged(object sender, EventArgs e)
        {
            // si la checkbox est cochée, le datetimepicker devient visible
            // si la checkbox est decochée, le datetimepicker medecin devient invisible
            if (chbxDate.Checked)
            {
                datebox.Visible = true;
            }
            else
            {
                datebox.Visible = false;
            }
        }

        //
        // ------------------------------------- BOUTON -------------------------------------
        //

        private void button1_Click(object sender, EventArgs e)
        {
            // initialisation d'une liste contenant tout les rapports

            List<rapport> rapports = gsbData.rapports.ToList();

            // Controle de saisie, au moins une checkbox doit etre cochée

            if (chbxMedecin.Checked || chbxDate.Checked || chbxVisiteur.Checked)
            {

                // filtrages, si la checkbox est cochée le filtre s'active
                // chaque filtre retire des rapports a la liste rapports

                if (chbxDate.Checked)
                {
                    rapports = (from r in rapports
                                where r.date == datebox.Value.Date
                                select r).ToList();
                }

                if (chbxMedecin.Checked)
                {
                    rapports = (from r in rapports
                                where r.medecin == (medecin)cmbxMedecin.SelectedValue
                                select r).ToList();
                }

                if (chbxVisiteur.Checked)
                {
                    rapports = (from r in rapports
                                where r.visiteur == (visiteur)cmbxVisiteur.SelectedValue
                                select r).ToList();
                }

                // Parse puis generation du Xml a produire a l'aide de Linq to Xml

                var xml = new XElement("Rapports", rapports.Select(x => new XElement("rapport",
                                               new XAttribute("id", x.id),
                                               new XElement("date", x.date),
                                               new XElement("bilan", x.bilan),
                                               new XElement("motif", x.motif),
                                               new XElement("idVisiteur", x.idVisiteur),
                                               new XElement("idMedecin", x.idMedecin),
                                                 new XElement("Medicaments", x.offrirs.Select(y => new XElement("Medicament",
                                                  new XAttribute("id", y.idMedicament),
                                                  new XAttribute("quantité", y.quantite)
                                                 )))
                                               )));
                xml.Save("rapports.xml");
                MessageBox.Show("fichier XML generé avec succès");
            }
            else
            {
                // si aucune checkbox n'est cochée, message d'erreur
                MessageBox.Show("Veuillez choisir au moins un filtre.");
            }
        }


    }
}
