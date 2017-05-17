namespace gsbRapports
{
    partial class FormEdition
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
            this.motiftxt = new System.Windows.Forms.TextBox();
            this.bdgRapport = new System.Windows.Forms.BindingSource(this.components);
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
            this.button1 = new System.Windows.Forms.Button();
            this.bdgOffrir = new System.Windows.Forms.BindingSource(this.components);
            this.addMed = new System.Windows.Forms.Button();
            this.cbxMedic = new System.Windows.Forms.ComboBox();
            this.txtQteAdd = new System.Windows.Forms.TextBox();
            this.btnSupMed = new System.Windows.Forms.Button();
            this.cbxOfrir = new System.Windows.Forms.ComboBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQte = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgmedic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOffrir)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(626, 28);
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
            this.ajouterToolStripMenuItem3.Click += new System.EventHandler(this.ajouterToolStripMenuItem3_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.rechercherToolStripMenuItem.Text = "&Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.modifierToolStripMenuItem.Text = "modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
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
            // motiftxt
            // 
            this.motiftxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgRapport, "motif", true));
            this.motiftxt.Location = new System.Drawing.Point(149, 188);
            this.motiftxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.motiftxt.Name = "motiftxt";
            this.motiftxt.Size = new System.Drawing.Size(447, 22);
            this.motiftxt.TabIndex = 23;
            // 
            // bdgRapport
            // 
            this.bdgRapport.DataSource = typeof(gsbRapports.rapport);
            // 
            // lblmotif
            // 
            this.lblmotif.AutoSize = true;
            this.lblmotif.Location = new System.Drawing.Point(40, 193);
            this.lblmotif.Name = "lblmotif";
            this.lblmotif.Size = new System.Drawing.Size(38, 17);
            this.lblmotif.TabIndex = 22;
            this.lblmotif.Text = "Motif";
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Location = new System.Drawing.Point(38, 234);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(39, 17);
            this.lblBilan.TabIndex = 21;
            this.lblBilan.Text = "Bilan";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(40, 149);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(38, 17);
            this.lbldate.TabIndex = 20;
            this.lbldate.Text = "Date";
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Location = new System.Drawing.Point(40, 103);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(61, 17);
            this.lblMed.TabIndex = 19;
            this.lblMed.Text = "Medecin";
            // 
            // bilantxt
            // 
            this.bilantxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgRapport, "bilan", true));
            this.bilantxt.Location = new System.Drawing.Point(149, 234);
            this.bilantxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilantxt.Multiline = true;
            this.bilantxt.Name = "bilantxt";
            this.bilantxt.Size = new System.Drawing.Size(447, 61);
            this.bilantxt.TabIndex = 18;
            // 
            // cbxMedecin
            // 
            this.cbxMedecin.DataSource = this.bdgMedecin;
            this.cbxMedecin.DisplayMember = "nom";
            this.cbxMedecin.FormattingEnabled = true;
            this.cbxMedecin.Location = new System.Drawing.Point(149, 103);
            this.cbxMedecin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMedecin.Name = "cbxMedecin";
            this.cbxMedecin.Size = new System.Drawing.Size(121, 24);
            this.cbxMedecin.TabIndex = 17;
            this.cbxMedecin.ValueMember = "id";
            // 
            // datebox
            // 
            this.datebox.Enabled = false;
            this.datebox.Location = new System.Drawing.Point(149, 149);
            this.datebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(200, 22);
            this.datebox.TabIndex = 16;
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(40, 61);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(55, 17);
            this.lblVisiteur.TabIndex = 15;
            this.lblVisiteur.Text = "Visiteur";
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(144, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(267, 36);
            this.titre.TabIndex = 14;
            this.titre.Text = "Modifier un rapport";
            // 
            // cbxVisiteur
            // 
            this.cbxVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteur, "nom", true));
            this.cbxVisiteur.DataSource = this.bdgVisiteur;
            this.cbxVisiteur.DisplayMember = "nom";
            this.cbxVisiteur.Enabled = false;
            this.cbxVisiteur.FormattingEnabled = true;
            this.cbxVisiteur.Location = new System.Drawing.Point(149, 61);
            this.cbxVisiteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxVisiteur.Name = "cbxVisiteur";
            this.cbxVisiteur.Size = new System.Drawing.Size(121, 24);
            this.cbxVisiteur.TabIndex = 13;
            this.cbxVisiteur.ValueMember = "id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 551);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 49);
            this.button1.TabIndex = 24;
            this.button1.Text = "Enregistrer Modifications";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEnreg);
            // 
            // bdgOffrir
            // 
            this.bdgOffrir.DataSource = typeof(gsbRapports.offrir);
            // 
            // addMed
            // 
            this.addMed.Location = new System.Drawing.Point(303, 20);
            this.addMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMed.Name = "addMed";
            this.addMed.Size = new System.Drawing.Size(100, 34);
            this.addMed.TabIndex = 26;
            this.addMed.Text = "Ajouter";
            this.addMed.UseVisualStyleBackColor = true;
            this.addMed.Click += new System.EventHandler(this.addMed_Click);
            // 
            // cbxMedic
            // 
            this.cbxMedic.FormattingEnabled = true;
            this.cbxMedic.Location = new System.Drawing.Point(6, 32);
            this.cbxMedic.Name = "cbxMedic";
            this.cbxMedic.Size = new System.Drawing.Size(142, 24);
            this.cbxMedic.TabIndex = 31;
            // 
            // txtQteAdd
            // 
            this.txtQteAdd.Location = new System.Drawing.Point(182, 32);
            this.txtQteAdd.Name = "txtQteAdd";
            this.txtQteAdd.Size = new System.Drawing.Size(100, 22);
            this.txtQteAdd.TabIndex = 34;
            // 
            // btnSupMed
            // 
            this.btnSupMed.Location = new System.Drawing.Point(41, 68);
            this.btnSupMed.Name = "btnSupMed";
            this.btnSupMed.Size = new System.Drawing.Size(142, 42);
            this.btnSupMed.TabIndex = 28;
            this.btnSupMed.Text = "Supprimer Medicament";
            this.btnSupMed.UseVisualStyleBackColor = true;
            this.btnSupMed.Click += new System.EventHandler(this.btnSupMed_Click);
            // 
            // cbxOfrir
            // 
            this.cbxOfrir.FormattingEnabled = true;
            this.cbxOfrir.Location = new System.Drawing.Point(25, 31);
            this.cbxOfrir.Name = "cbxOfrir";
            this.cbxOfrir.Size = new System.Drawing.Size(163, 24);
            this.cbxOfrir.TabIndex = 32;
            this.cbxOfrir.SelectedValueChanged += new System.EventHandler(this.cbxOfrir_SelectedValueChanged);
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(297, 31);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(100, 22);
            this.txtQte.TabIndex = 33;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(297, 68);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(94, 42);
            this.btnModif.TabIndex = 35;
            this.btnModif.Text = "Modifier Quantité";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQte);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnModif);
            this.groupBox1.Controls.Add(this.txtQte);
            this.groupBox1.Controls.Add(this.cbxOfrir);
            this.groupBox1.Controls.Add(this.btnSupMed);
            this.groupBox1.Location = new System.Drawing.Point(146, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 205);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicaments Offerts";
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Location = new System.Drawing.Point(213, 31);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(70, 17);
            this.lblQte.TabIndex = 37;
            this.lblQte.Text = "Quantité :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtQteAdd);
            this.groupBox2.Controls.Add(this.cbxMedic);
            this.groupBox2.Controls.Add(this.addMed);
            this.groupBox2.Location = new System.Drawing.Point(25, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 66);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter Medicament";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Quantité";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.motiftxt);
            this.groupBox3.Controls.Add(this.lblmotif);
            this.groupBox3.Controls.Add(this.lblBilan);
            this.groupBox3.Controls.Add(this.lbldate);
            this.groupBox3.Controls.Add(this.lblMed);
            this.groupBox3.Controls.Add(this.bilantxt);
            this.groupBox3.Controls.Add(this.cbxMedecin);
            this.groupBox3.Controls.Add(this.datebox);
            this.groupBox3.Controls.Add(this.lblVisiteur);
            this.groupBox3.Controls.Add(this.titre);
            this.groupBox3.Controls.Add(this.cbxVisiteur);
            this.groupBox3.Location = new System.Drawing.Point(0, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 638);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // FormEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 662);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEdition";
            this.Text = "FormEdition";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgmedic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOffrir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.BindingSource bdgRapport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bdgOffrir;
        private System.Windows.Forms.Button addMed;
        private System.Windows.Forms.ComboBox cbxMedic;
        private System.Windows.Forms.TextBox txtQteAdd;
        private System.Windows.Forms.Button btnSupMed;
        private System.Windows.Forms.ComboBox cbxOfrir;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}