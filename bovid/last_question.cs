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
    public partial class last_question : Form
    {
        public last_question()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            last_choice form3890 = new last_choice();
            form3890.ShowDialog();
            

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will be taken to the hospital for further tests/treatment", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
            //Form1 form9 = new Form1();
            //form9.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void last_question_Load(object sender, EventArgs e)
        {

        }
    }
}
