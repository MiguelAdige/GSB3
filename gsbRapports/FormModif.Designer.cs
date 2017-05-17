namespace gsbRapports
{
    partial class FormModif
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
            this.bdgRapport = new System.Windows.Forms.BindingSource(this.components);
            this.lbldate = new System.Windows.Forms.Label();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.cbxVisiteur = new System.Windows.Forms.ComboBox();
            this.gridRapport = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bdgMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.btnAfficher = new System.Windows.Forms.Button();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            // 
            // médicamentToolStripMenuItem
            // 
            this.médicamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.gérerToolStripMenuItem});
            this.médicamentToolStripMenuItem.Name = "médicamentToolStripMenuItem";
            this.médicamentToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.médicamentToolStripMenuItem.Text = "&Médicament";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.ajouterToolStripMenuItem.Text = "&Gérer";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.gérerToolStripMenuItem.Text = "&Liste";
            // 
            // médecinToolStripMenuItem
            // 
            this.médecinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.majToolStripMenuItem});
            this.médecinToolStripMenuItem.Name = "médecinToolStripMenuItem";
            this.médecinToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.médecinToolStripMenuItem.Text = "Mé&decin";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.ajouterToolStripMenuItem1.Text = "&Gérer";
            // 
            // majToolStripMenuItem
            // 
            this.majToolStripMenuItem.Name = "majToolStripMenuItem";
            this.majToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.majToolStripMenuItem.Text = "&Dernier rapport";
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.majToolStripMenuItem1});
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.visiteurToolStripMenuItem.Text = "&Visiteur";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.ajouterToolStripMenuItem2.Text = "&Gérer";
            // 
            // majToolStripMenuItem1
            // 
            this.majToolStripMenuItem1.Name = "majToolStripMenuItem1";
            this.majToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.majToolStripMenuItem1.Text = "&Rapports";
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem3,
            this.rechercherToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rapportToolStripMenuItem.Text = "&Rapport";
            // 
            // ajouterToolStripMenuItem3
            // 
            this.ajouterToolStripMenuItem3.Name = "ajouterToolStripMenuItem3";
            this.ajouterToolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            this.ajouterToolStripMenuItem3.Text = "&Ajouter";
            this.ajouterToolStripMenuItem3.Click += new System.EventHandler(this.ajouterToolStripMenuItem3_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rechercherToolStripMenuItem.Text = "&Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.modifierToolStripMenuItem.Text = "modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // bdgVisiteur
            // 
            this.bdgVisiteur.DataSource = typeof(gsbRapports.visiteur);
            // 
            // bdgRapport
            // 
            this.bdgRapport.DataSource = typeof(gsbRapports.rapport);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(67, 110);
            this.lbldate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 13;
            this.lbldate.Text = "Date";
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(67, 73);
            this.lblVisiteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(41, 13);
            this.lblVisiteur.TabIndex = 11;
            this.lblVisiteur.Text = "Visiteur";
            // 
            // cbxVisiteur
            // 
            this.cbxVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteur, "nom", true));
            this.cbxVisiteur.DataSource = this.bdgVisiteur;
            this.cbxVisiteur.DisplayMember = "nom";
            this.cbxVisiteur.FormattingEnabled = true;
            this.cbxVisiteur.Location = new System.Drawing.Point(149, 73);
            this.cbxVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.cbxVisiteur.Name = "cbxVisiteur";
            this.cbxVisiteur.Size = new System.Drawing.Size(92, 21);
            this.cbxVisiteur.TabIndex = 10;
            this.cbxVisiteur.ValueMember = "id";
            // 
            // gridRapport
            // 
            this.gridRapport.AutoGenerateColumns = false;
            this.gridRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.idVisiteurDataGridViewTextBoxColumn1,
            this.idMedecinDataGridViewTextBoxColumn1,
            this.Modifier});
            this.gridRapport.DataSource = this.bdgRapport;
            this.gridRapport.Location = new System.Drawing.Point(70, 195);
            this.gridRapport.Name = "gridRapport";
            this.gridRapport.Size = new System.Drawing.Size(525, 150);
            this.gridRapport.TabIndex = 14;
            this.gridRapport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRapport_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // idVisiteurDataGridViewTextBoxColumn1
            // 
            this.idVisiteurDataGridViewTextBoxColumn1.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn1.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn1.Name = "idVisiteurDataGridViewTextBoxColumn1";
            // 
            // idMedecinDataGridViewTextBoxColumn1
            // 
            this.idMedecinDataGridViewTextBoxColumn1.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn1.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn1.Name = "idMedecinDataGridViewTextBoxColumn1";
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bdgMedecin
            // 
            this.bdgMedecin.DataSource = typeof(gsbRapports.medecin);
            // 
            // btnAfficher
            // 
            this.btnAfficher.AutoEllipsis = true;
            this.btnAfficher.Location = new System.Drawing.Point(149, 157);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 15;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(149, 110);
            this.datebox.Margin = new System.Windows.Forms.Padding(2);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(151, 20);
            this.datebox.TabIndex = 16;
            // 
            // FormModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 478);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.gridRapport);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.cbxVisiteur);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormModif";
            this.Text = "FormModif";
            this.Load += new System.EventHandler(this.FormModif_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).EndInit();
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
        private System.Windows.Forms.BindingSource bdgRapport;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.ComboBox cbxVisiteur;
        private System.Windows.Forms.DataGridView gridRapport;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.BindingSource bdgMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
    }
}