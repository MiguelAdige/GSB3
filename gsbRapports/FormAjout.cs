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
    public partial class FormAjout : Form
    {
        private gsbrapports2016Entities gsbData;

        //
        // ------------------------------------- Constructeur -------------------------------------
        //

        public FormAjout(gsbrapports2016Entities gsb)
        {
            InitializeComponent();
            this.gsbData = gsb;

            // initialisation des bindingsSource

            this.bdgVisiteur.DataSource = gsb.visiteurs.ToList();
            this.bdgMedecin.DataSource = gsb.medecins.ToList();
            this.bdgmedic.DataSource = gsb.medicaments.ToList();

            // initialisation des valuemember des comboboxes a null
            // les combobox retourneront ainsi des objets

            cbxMedecin.ValueMember = null;
            cbxVisiteur.ValueMember = null;
        }

        private void FormAjout_Load(object sender, EventArgs e)
        {

        }

        //
        // ------------------------------------- MENU -------------------------------------
        //

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
        // ------------------------------------- Ajout/suppression ligne datagridview -------------------------------------
        //

        private void addMed_Click(object sender, EventArgs e)
        {
            //quand le bouton est cliqué, une nouvelle ligne s'ajoute a gridMedic
            gridMedic.Rows.Add();
        }


        private void gridMedic_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //quand le bouton est cliqué, la ligne sur laquelle se situe le bouton est supprimée
            gridMedic.Rows.RemoveAt(e.RowIndex);
        }

        //
        // ------------------------------------- Bouton validation  -------------------------------------
        //

        private void validAjout_Click(object sender, EventArgs e)
        {
            bool validMedic = false;
            int n;

            // ---- Controles de saisies -----

            //boucle controlant chaque ligne du datagridview gridMedic 
            // afin de verifier que tout ses champs soient remplis correctement
            try
            {
                foreach (DataGridViewRow row in gridMedic.Rows)
                {

                        int i = Convert.ToInt32(row.Cells[1].Value.ToString());
                        if (row.Cells[0].Value.ToString() == "" || row.Cells[1].Value.ToString() == "" || !Int32.TryParse(row.Cells[1].Value.ToString(), out n))
                        {
                            validMedic = true;
                        }

                    }
            }
            catch
            {
                MessageBox.Show("Une erreur c'est produitute. Veuillez saisir des informations correct !");
                validMedic = false;
            }

            // controle verifiant que tout les champs textes soient bien remplis correctement.
            // le cas échéant un message d'erreur est renvoyé
            if (motiftxt.Text == "")
            {
                MessageBox.Show("Veuillez renseigner le motif");
            }
            if (bilantxt.Text == "")
            {
                MessageBox.Show("Veuillez renseigner le bilan");
            }
            else if (validMedic)
            {
                MessageBox.Show("Veuillez renseigner toutes les informations de medicaments correctement");
            }
         // ---- recuperation et sauvegarde des données ----
             
            else
            {
                // creation du nouveau rapport 
                rapport r = new rapport();

                // recuperation des données du formulaire et insertion dans le nouveau rapport
                 
                r.visiteur = (visiteur)cbxVisiteur.SelectedValue;
                r.medecin = (medecin)cbxMedecin.SelectedValue;
                r.date = datebox.Value;
                r.bilan = bilantxt.Text;
                r.motif = motiftxt.Text;

                //sauvegarde du rapport
                gsbData.rapports.Add(r);
                gsbData.SaveChanges();

                //recuperation de l'id du nouveau rapport
                int idRapport = r.id;

                // boucle transformant chaque ligne du datagridview gridMedic en objet offrir
                // puis sauvegarde de chaque objet dans la table offrir

                foreach (DataGridViewRow row in gridMedic.Rows)
                {
                    offrir o = new offrir();

                    o.idMedicament = (string)row.Cells[0].Value;
                    o.idRapport = idRapport;
                    try
                    {
                        o.quantite = Convert.ToInt32(row.Cells[1].Value.ToString());
                    }
                    catch
                    {

                    }
                    o.medicament = (from m in this.gsbData.medicaments
                                    where m.id == o.idMedicament
                                    select m).ToList()[0];

                    r.offrirs.Add(o);
                    gsbData.offrirs.Add(o);
                }

                //sauvegarde en base de donnée
                gsbData.SaveChanges();

                MessageBox.Show("Rapport ajouté.");
            }
        }


    }
}
