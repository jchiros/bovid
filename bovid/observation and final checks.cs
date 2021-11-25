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
    public partial class observation_and_final_checks : Form
    {
        public observation_and_final_checks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form10 = new Form2();
            form10.ShowDialog();
        }

        private void observation_and_final_checks_Load(object sender, EventArgs e)
        {

        }
    }
}
