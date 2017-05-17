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
    public partial class RapAjout : Form
    {
        private gsbrapports2016Entities gsbData;

        public RapAjout()
        {
            this.InitializeComponent();
            this.gsbData = new gsbrapports2016Entities();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FormAjout f = new FormAjout(gsbData);
            f.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FormCherche f = new FormCherche(gsbData);
            f.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FormModif f = new FormModif(gsbData);
            f.Show();
        }
    }
}
