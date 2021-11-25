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
    public partial class medcert_screen : Form
    {
        public medcert_screen()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            medcert form54 = new medcert();
            form54.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            vaccination form32 = new vaccination ();
            form32.ShowDialog();
        }

        private void medcert_screen_Load(object sender, EventArgs e)
        {

        }
    }
}
