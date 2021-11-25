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
    public partial class return_load : Form
    {
        public return_load()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var before = this.progressBar1.Value;
            this.progressBar1.Increment(1);
            var after = this.progressBar1.Value;
            if (after > before && after == this.progressBar1.Maximum)
            {
                MessageBox.Show("Thank you for using this system, you can now return home", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                dose nextform = new dose();
                nextform.ShowDialog();
            }
        }

        private void return_load_Load(object sender, EventArgs e)
        {

        }
    }
}
