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
    public partial class FormEdition : Form
    {
        private gsbrapports2016Entities gsbData;
        private rapport leRapport;
        private List<offrir> meds;
        private List<medicament> medsNom;
        private List<medicament> toutMeds;

        //
        // ------------------------------------- Constructeur -------------------------------------
        //


        public FormEdition(gsbrapports2016Entities gsb, int idR)
        {
            InitializeComponent();
            this.gsbData = gsb;


            // initialisation des valuemember des comboboxes a null
            // les combobox retourneront ainsi des objets

            cbxVisiteur.ValueMember = null;
            cbxMedecin.ValueMember = null;
            cbxMedic.ValueMember = null;
            cbxOfrir.ValueMember = null;

            //recuperation du rapport a modifier depuis son id

            this.leRapport = (from r in this.gsbData.rapports
                              join v in this.gsbData.visiteurs on r.idVisiteur equals v.id
                              join m in this.gsbData.medecins on r.idMedecin equals m.id
                              where r.id == idR
                              select r).ToList()[0];

            // initialisation des listes alimentants les comboboxes de medicaments

            this.meds = this.leRapport.offrirs.ToList();        // recuperation de la liste de tout les medicaments offerts (objets offrir)     
            this.toutMeds = this.gsbData.medicaments.ToList();  // recuperation de la liste de tout les medicaments existants (objets medicaments)     

            this.medsNom = new List<medicament>();              // initialisation de la liste de tout les medicaments offerts (objets medicaments)
                                                                // cette liste sert a recuperer les nom commerciaux des medicaments offerts     

            // cette boucle enlève de la liste de tout les medicaments ceux qui sont offerts dans le rapport
            // et ajoute ces medicaments a la liste des medicaments offerts (en objet medicaments)
            foreach (offrir o in this.meds) {
                this.medsNom.Add(o.medicament);
                this.toutMeds.Remove(o.medicament);
            }

            // initialisation des bindingsSource

            this.bdgRapport.DataSource = this.leRapport;
            this.bdgVisiteur.DataSource = this.leRapport.visiteur;
            this.bdgMedecin.DataSource = gsb.medecins.ToList();
            this.bdgmedic.DataSource = gsb.medicaments.ToList();

            // initialisation des comboboxes, des valeurs de ces comboboxes et du champ quantités de medicaments
            cbxIni();
            MajQuantite();
            cbxMedecin.SelectedItem = this.leRapport.medecin;

        }

        //
        // ------------------------------------- MENU -------------------------------------
        //

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
        // ------------------------------------- Methodes autres -------------------------------------
        //

        // Methode de rafraichissement des combobox, vide puis recrée les combobox
        private void cbxIni()
        {
            cbxOfrir.DataSource = null;
            cbxMedic.DataSource = null;
            cbxMedic.Items.Clear();
            cbxOfrir.Items.Clear();
            cbxOfrir.DataSource = this.medsNom;
            cbxMedic.DataSource = this.toutMeds;
            cbxOfrir.DisplayMember = "nomCommercial";
            cbxMedic.DisplayMember = "nomCommercial";
        }

        //retourne l'objet offrir du rapport lié au medicament entré en paramètre
        private offrir offrirFromMed(medicament m)
        {
            offrir offrirSelected = (from o in this.meds
                                     where o.medicament == m
                                     select o).ToList().FirstOrDefault();
            return offrirSelected;
        }

        // recuperation de l'objet offrir lié au medicament, pour ce rapport, selectionné par la combobox de modification de medicament  
        // puis recuperation de la quantité de ce medicament offert et insertion de cette quantité dans le champ texte d'affichage/modification de quantité
        private void MajQuantite()
        {
            // controle de saisie, verification de la combobox de modification de medicament
            // afin de verifier que la selection ne soit pas null
            if (cbxOfrir.DataSource != null)
            {
                try
                {
                    txtQte.Text = Convert.ToString(offrirFromMed((medicament)cbxOfrir.SelectedValue).quantite);
                }
                catch
                {
                    MessageBox.Show("Veuillez entrer une quantité valide");
                }
            }
         }

    //
    // ------------------------------------- Gestion des medicaments -------------------------------------
    //
    // -------- Boutons --------
    //


    // methode de suppression de medicament de la table offrirs, recupère le medicament dans la checkbox, modifie les listes de medicments offerts
    //  et disponibles puis mets a jour les comboboxes et enfin recupère l'objet offrir lié a ce medicament et le supprime de la liste offrirs du rapport 
    private void btnSupMed_Click(object sender, EventArgs e)
        {
            medicament m = (medicament)cbxOfrir.SelectedValue;
            this.medsNom.Remove(m);
            this.toutMeds.Add(m);
            cbxIni();
            this.leRapport.offrirs.Remove(offrirFromMed(m));
            this.meds.Remove(offrirFromMed(m));
            MessageBox.Show("medicament supprimmé");
        }


         // methode d'ajout de medicament a la table offrirs, recupère le medicament selectionné et la quantité entrée
         // crée un objet offrir a partir de ces données et l'insère dans la liste offrirs du rapport puis mets a jout les comboboxes
        private void addMed_Click(object sender, EventArgs e)
        {
            offrir o = new offrir();
            int res;

             //controle de saisie verifiant que le medicament et sa quantité soient saisis correctement  
            if (Int32.TryParse(txtQteAdd.Text, out res) || !(txtQteAdd.Text == ""))
            {
                o.medicament = (medicament)cbxMedic.SelectedValue;
                o.quantite = res;
                o.rapport = this.leRapport;
                o.idMedicament = o.medicament.id;
                o.idRapport = o.rapport.id;

                this.medsNom.Add(o.medicament);
                this.toutMeds.Remove(o.medicament);
                this.meds.Add(o);
                this.leRapport.offrirs.Add(o);
                MessageBox.Show("Medicament ajouté");
                cbxIni();
                txtQteAdd.Text = "";

            }
            else
            {
                MessageBox.Show("Veuillez entrer une quantité valide");
            }
        }

        // methode de modification de medicament a la table offrirs, recupère le medicament selectionné et la quantité entrée
        // recupère l'objet offrir lié au medicament et modifie sa quantité, puis reinitialise les comboboxes
        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(txtQte.Text);

                int res;
                if (Int32.TryParse(txtQte.Text, out res) || !(txtQte.Text == ""))
                {
                    offrirFromMed((medicament)cbxOfrir.SelectedValue).quantite = res;
                    MessageBox.Show("Quantité modifiée");
                    cbxIni();
                }
                else
                {
                    MessageBox.Show("Veuillez entrer une quantité valide");
                }
            }
            catch
            {
                MessageBox.Show("Veuillez entrer une quantité valide");
            }

            
        }

        //
        // -------- Autres --------
        //

            // a chaque changement de la combobox de modification de medicament
        private void cbxOfrir_SelectedValueChanged(object sender, EventArgs e)
        {
            MajQuantite();
        }

        //
        // ------------------------------------- Bouton de validation -------------------------------------
        //

            //recuperation des nouvelles entrées du rapport et validation des changements dans la base de données
        private void btnEnreg(object sender, EventArgs e)
        {
            this.leRapport.visiteur = (visiteur)cbxVisiteur.SelectedValue;
            this.leRapport.medecin = (medecin)cbxMedecin.SelectedValue;
            this.leRapport.date = datebox.Value;
            this.leRapport.bilan = bilantxt.Text;
            this.leRapport.motif = motiftxt.Text;
            gsbData.SaveChanges();
            MessageBox.Show("Rapport modifié avec succès");
        }


    }
}
