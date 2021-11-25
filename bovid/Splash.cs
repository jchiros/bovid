using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bovid
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var before = this.progressBar1.Value;
            this.progressBar1.Increment(1);
            var after = this.progressBar1.Value;
            if (after > before && after == this.progressBar1.Maximum)
            {
                MessageBox.Show("Welcome to Electronic Vaccination System...", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                dose nextform = new dose();
                nextform.ShowDialog();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}