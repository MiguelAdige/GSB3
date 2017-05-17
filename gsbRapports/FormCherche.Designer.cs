namespace gsbRapports
{
    partial class FormCherche
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
            this.bdgMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.bdgVisiteur = new System.Windows.Forms.BindingSource(this.components);
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbxDate = new System.Windows.Forms.CheckBox();
            this.chbxMedecin = new System.Windows.Forms.CheckBox();
            this.chbxVisiteur = new System.Windows.Forms.CheckBox();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.cmbxMedecin = new System.Windows.Forms.ComboBox();
            this.cmbxVisiteur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdgMedecin
            // 
            this.bdgMedecin.DataSource = typeof(gsbRapports.medecin);
            // 
            // bdgVisiteur
            // 
            this.bdgVisiteur.DataSource = typeof(gsbRapports.visiteur);
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
            this.menuStrip1.Size = new System.Drawing.Size(985, 28);
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
            this.ajouterToolStripMenuItem3.Click += new System.EventHandler(this.ajouterToolStripMenuItem3_Click_1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Generer XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 44);
            this.label2.TabIndex = 22;
            this.label2.Text = "Visualiser rapports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Trier par :";
            // 
            // chbxDate
            // 
            this.chbxDate.AutoSize = true;
            this.chbxDate.Location = new System.Drawing.Point(704, 262);
            this.chbxDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxDate.Name = "chbxDate";
            this.chbxDate.Size = new System.Drawing.Size(60, 21);
            this.chbxDate.TabIndex = 20;
            this.chbxDate.Text = "Date";
            this.chbxDate.UseVisualStyleBackColor = true;
            this.chbxDate.CheckedChanged += new System.EventHandler(this.chbxDate_CheckedChanged);
            // 
            // chbxMedecin
            // 
            this.chbxMedecin.AutoSize = true;
            this.chbxMedecin.Location = new System.Drawing.Point(469, 263);
            this.chbxMedecin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxMedecin.Name = "chbxMedecin";
            this.chbxMedecin.Size = new System.Drawing.Size(83, 21);
            this.chbxMedecin.TabIndex = 19;
            this.chbxMedecin.Text = "Medecin";
            this.chbxMedecin.UseVisualStyleBackColor = true;
            this.chbxMedecin.CheckedChanged += new System.EventHandler(this.chbxMedecin_CheckedChanged);
            // 
            // chbxVisiteur
            // 
            this.chbxVisiteur.AutoSize = true;
            this.chbxVisiteur.Location = new System.Drawing.Point(259, 263);
            this.chbxVisiteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxVisiteur.Name = "chbxVisiteur";
            this.chbxVisiteur.Size = new System.Drawing.Size(77, 21);
            this.chbxVisiteur.TabIndex = 18;
            this.chbxVisiteur.Text = "Visiteur";
            this.chbxVisiteur.UseVisualStyleBackColor = true;
            this.chbxVisiteur.CheckedChanged += new System.EventHandler(this.chbxVisiteur_CheckedChanged);
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(663, 314);
            this.datebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(200, 22);
            this.datebox.TabIndex = 17;
            this.datebox.Visible = false;
            // 
            // cmbxMedecin
            // 
            this.cmbxMedecin.DataSource = this.bdgMedecin;
            this.cmbxMedecin.DisplayMember = "nom";
            this.cmbxMedecin.FormattingEnabled = true;
            this.cmbxMedecin.Location = new System.Drawing.Point(455, 313);
            this.cmbxMedecin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxMedecin.Name = "cmbxMedecin";
            this.cmbxMedecin.Size = new System.Drawing.Size(121, 24);
            this.cmbxMedecin.TabIndex = 16;
            this.cmbxMedecin.ValueMember = "id";
            this.cmbxMedecin.Visible = false;
            // 
            // cmbxVisiteur
            // 
            this.cmbxVisiteur.DataSource = this.bdgVisiteur;
            this.cmbxVisiteur.DisplayMember = "nom";
            this.cmbxVisiteur.FormattingEnabled = true;
            this.cmbxVisiteur.Location = new System.Drawing.Point(235, 313);
            this.cmbxVisiteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxVisiteur.Name = "cmbxVisiteur";
            this.cmbxVisiteur.Size = new System.Drawing.Size(121, 24);
            this.cmbxVisiteur.TabIndex = 15;
            this.cmbxVisiteur.Visible = false;
            // 
            // FormCherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbxDate);
            this.Controls.Add(this.chbxMedecin);
            this.Controls.Add(this.chbxVisiteur);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.cmbxMedecin);
            this.Controls.Add(this.cmbxVisiteur);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCherche";
            this.Text = "FormCherche";
            this.Load += new System.EventHandler(this.FormCherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bdgMedecin;
        private System.Windows.Forms.BindingSource bdgVisiteur;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbxDate;
        private System.Windows.Forms.CheckBox chbxMedecin;
        private System.Windows.Forms.CheckBox chbxVisiteur;
        private System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.ComboBox cmbxMedecin;
        private System.Windows.Forms.ComboBox cmbxVisiteur;
    }
}