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
    public partial class vaccination : Form
    {
        public vaccination()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            observation_and_final_checks form11 = new observation_and_final_checks();
            form11.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            var before = this.progressBar1.Value;
            this.progressBar1.Increment(1);
            var after = this.progressBar1.Value;
            if (after > before && after == this.progressBar1.Maximum)
            {
                this.button1.Enabled = true;
                //MessageBox.Show("Proceed to the next area...", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void vaccination_Load(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.timer1.Start();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
