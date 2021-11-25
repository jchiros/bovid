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
    public partial class waiver : Form
    {
        public waiver()
        {
            InitializeComponent();
        }

        private void waiver_agree_Click(object sender, EventArgs e)
        {
            this.Hide();
            questions form3 = new questions();
            form3.ShowDialog();

        }

        private void waiver_text_Click(object sender, EventArgs e)
        {

        }

        private void waiver_decline_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("You must agree to this waiver","Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
