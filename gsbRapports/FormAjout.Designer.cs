namespace gsbRapports
{
    partial class FormAjout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.majToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.majToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bdgVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bdgMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.bdgmedic = new System.Windows.Forms.BindingSource(this.components);
            this.addMed = new System.Windows.Forms.Button();
            this.gridMedic = new System.Windows.Forms.DataGridView();
            this.medic = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.motiftxt = new System.Windows.Forms.TextBox();
            this.lblmotif = new System.Windows.Forms.Label();
            this.lblBilan = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblMed = new System.Windows.Forms.Label();
            this.bilantxt = new System.Windows.Forms.TextBox();
            this.cbxMedecin = new System.Windows.Forms.ComboBox();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.cbxVisiteur = new System.Windows.Forms.ComboBox();
            this.validAjout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgmedic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.médicamentToolStripMenuItem,
            this.médecinToolStripMenuItem,
            this.visiteurToolStripMenuItem,
            this.rapportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            // 
            // médicamentToolStripMenuItem
            // 
            this.médicamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.gérerToolStripMenuItem});
            this.médicamentToolStripMenuItem.Name = "médicamentToolStripMenuItem";
            this.médicamentToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.médicamentToolStripMenuItem.Text = "&Médicament";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.ajouterToolStripMenuItem.Text = "&Gérer";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.gérerToolStripMenuItem.Text = "&Liste";
            // 
            // médecinToolStripMenuItem
            // 
            this.médecinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.majToolStripMenuItem});
            this.médecinToolStripMenuItem.Name = "médecinToolStripMenuItem";
            this.médecinToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.médecinToolStripMenuItem.Text = "Mé&decin";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.ajouterToolStripMenuItem1.Text = "&Gérer";
            // 
            // majToolStripMenuItem
            // 
            this.majToolStripMenuItem.Name = "majToolStripMenuItem";
            this.majToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.majToolStripMenuItem.Text = "&Dernier rapport";
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.majToolStripMenuItem1});
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.visiteurToolStripMenuItem.Text = "&Visiteur";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.ajouterToolStripMenuItem2.Text = "&Gérer";
            // 
            // majToolStripMenuItem1
            // 
            this.majToolStripMenuItem1.Name = "majToolStripMenuItem1";
            this.majToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.majToolStripMenuItem1.Text = "&Rapports";
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem3,
            this.rechercherToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.rapportToolStripMenuItem.Text = "&Rapport";
            // 
            // ajouterToolStripMenuItem3
            // 
            this.ajouterToolStripMenuItem3.Name = "ajouterToolStripMenuItem3";
            this.ajouterToolStripMenuItem3.Size = new System.Drawing.Size(181, 26);
            this.ajouterToolStripMenuItem3.Text = "&Ajouter";
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.rechercherToolStripMenuItem.Text = "&Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click_1);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.modifierToolStripMenuItem.Text = "modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click_1);
            // 
            // bdgVisiteur
            // 
            this.bdgVisiteur.DataSource = typeof(gsbRapports.visiteur);
            // 
            // bdgMedecin
            // 
            this.bdgMedecin.DataSource = typeof(gsbRapports.medecin);
            // 
            // bdgmedic
            // 
            this.bdgmedic.DataSource = typeof(gsbRapports.medicament);
            // 
            // addMed
            // 
            this.addMed.Location = new System.Drawing.Point(188, 482);
            this.addMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMed.Name = "addMed";
            this.addMed.Size = new System.Drawing.Size(103, 44);
            this.addMed.TabIndex = 28;
            this.addMed.Text = "Ajouter medicament";
            this.addMed.UseVisualStyleBackColor = true;
            this.addMed.Click += new System.EventHandler(this.addMed_Click);
            // 
            // gridMedic
            // 
            this.gridMedic.AllowUserToAddRows = false;
            this.gridMedic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medic,
            this.qte,
            this.supp});
            this.gridMedic.Location = new System.Drawing.Point(340, 452);
            this.gridMedic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridMedic.Name = "gridMedic";
            this.gridMedic.RowTemplate.Height = 24;
            this.gridMedic.Size = new System.Drawing.Size(445, 214);
            this.gridMedic.TabIndex = 27;
            this.gridMedic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMedic_CellContentClick_1);
            // 
            // medic
            // 
            this.medic.DataSource = this.bdgmedic;
            this.medic.DisplayMember = "nomCommercial";
            this.medic.DropDownWidth = 2;
            this.medic.HeaderText = "Medicament";
            this.medic.Name = "medic";
            this.medic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.medic.ValueMember = "id";
            this.medic.Width = 200;
            // 
            // qte
            // 
            this.qte.HeaderText = "quantité";
            this.qte.Name = "qte";
            this.qte.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // supp
            // 
            this.supp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.supp.HeaderText = "Supprimer";
            this.supp.Name = "supp";
            this.supp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.supp.Text = "Supprimer";
            this.supp.ToolTipText = "Supprimer";
            // 
            // motiftxt
            // 
            this.motiftxt.Location = new System.Drawing.Point(340, 293);
            this.motiftxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.motiftxt.Name = "motiftxt";
            this.motiftxt.Size = new System.Drawing.Size(447, 22);
            this.motiftxt.TabIndex = 26;
            // 
            // lblmotif
            // 
            this.lblmotif.AutoSize = true;
            this.lblmotif.Location = new System.Drawing.Point(231, 298);
            this.lblmotif.Name = "lblmotif";
            this.lblmotif.Size = new System.Drawing.Size(38, 17);
            this.lblmotif.TabIndex = 25;
            this.lblmotif.Text = "Motif";
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Location = new System.Drawing.Point(229, 340);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(39, 17);
            this.lblBilan.TabIndex = 24;
            this.lblBilan.Text = "Bilan";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(231, 255);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(38, 17);
            this.lbldate.TabIndex = 23;
            this.lbldate.Text = "Date";
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Location = new System.Drawing.Point(231, 208);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(61, 17);
            this.lblMed.TabIndex = 22;
            this.lblMed.Text = "Medecin";
            // 
            // bilantxt
            // 
            this.bilantxt.Location = new System.Drawing.Point(340, 340);
            this.bilantxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilantxt.Multiline = true;
            this.bilantxt.Name = "bilantxt";
            this.bilantxt.Size = new System.Drawing.Size(447, 61);
            this.bilantxt.TabIndex = 21;
            // 
            // cbxMedecin
            // 
            this.cbxMedecin.DataSource = this.bdgMedecin;
            this.cbxMedecin.DisplayMember = "nom";
            this.cbxMedecin.FormattingEnabled = true;
            this.cbxMedecin.Location = new System.Drawing.Point(340, 208);
            this.cbxMedecin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMedecin.Name = "cbxMedecin";
            this.cbxMedecin.Size = new System.Drawing.Size(121, 24);
            this.cbxMedecin.TabIndex = 20;
            this.cbxMedecin.ValueMember = "id";
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(340, 255);
            this.datebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(200, 22);
            this.datebox.TabIndex = 19;
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(231, 166);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(55, 17);
            this.lblVisiteur.TabIndex = 18;
            this.lblVisiteur.Text = "Visiteur";
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(335, 82);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(256, 36);
            this.titre.TabIndex = 17;
            this.titre.Text = "Ajouter un rapport";
            // 
            // cbxVisiteur
            // 
            this.cbxVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteur, "nom", true));
            this.cbxVisiteur.DataSource = this.bdgVisiteur;
            this.cbxVisiteur.DisplayMember = "nom";
            this.cbxVisiteur.FormattingEnabled = true;
            this.cbxVisiteur.Location = new System.Drawing.Point(340, 166);
            this.cbxVisiteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxVisiteur.Name = "cbxVisiteur";
            this.cbxVisiteur.Size = new System.Drawing.Size(121, 24);
            this.cbxVisiteur.TabIndex = 16;
            this.cbxVisiteur.ValueMember = "id";
            // 
            // validAjout
            // 
            this.validAjout.Location = new System.Drawing.Point(520, 700);
            this.validAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validAjout.Name = "validAjout";
            this.validAjout.Size = new System.Drawing.Size(155, 36);
            this.validAjout.TabIndex = 29;
            this.validAjout.Text = "Ajouter Rappport";
            this.validAjout.UseVisualStyleBackColor = true;
            this.validAjout.Click += new System.EventHandler(this.validAjout_Click);
            // 
            // FormAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 750);
            this.Controls.Add(this.validAjout);
            this.Controls.Add(this.addMed);
            this.Controls.Add(this.gridMedic);
            this.Controls.Add(this.motiftxt);
            this.Controls.Add(this.lblmotif);
            this.Controls.Add(this.lblBilan);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.bilantxt);
            this.Controls.Add(this.cbxMedecin);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.cbxVisiteur);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAjout";
            this.Text = "FormAjout";
            this.Load += new System.EventHandler(this.FormAjout_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgmedic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem majToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem majToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.BindingSource bdgVisiteur;
        private System.Windows.Forms.BindingSource bdgMedecin;
        private System.Windows.Forms.BindingSource bdgmedic;
        private System.Windows.Forms.Button addMed;
        private System.Windows.Forms.DataGridView gridMedic;
        private System.Windows.Forms.DataGridViewComboBoxColumn medic;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte;
        private System.Windows.Forms.DataGridViewButtonColumn supp;
        private System.Windows.Forms.TextBox motiftxt;
        private System.Windows.Forms.Label lblmotif;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.TextBox bilantxt;
        private System.Windows.Forms.ComboBox cbxMedecin;
        private System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.ComboBox cbxVisiteur;
        private System.Windows.Forms.Button validAjout;
    }
}