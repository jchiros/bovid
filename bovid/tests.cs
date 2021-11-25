using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bovid
{
    public partial class tests : Form
    {
        public tests()
        {
            InitializeComponent();
            
        }
      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bp1.Text.Length < 1 | bp2.Text.Length < 1 | hr.Text.Length < 1 | o2.Text.Length < 1)
            {
                MessageBox.Show("Please fill out all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tests form43 = new tests();
                form43.ShowDialog();


            }
            string val,val2,val3,val4;
            val = bp1.Text;
            val2 = bp2.Text;
            val3 = hr.Text;
            val4 = o2.Text;

            int res,res2,res3,res4;
            res = (int)Convert.ToInt64(val);
            res2 = (int)Convert.ToInt64(val2);
            res3 = (int)Convert.ToInt64(val3);
            res4 = (int)Convert.ToInt64(val4);


            var updatedFiles = new List<string>();

            if (res >= 120 | res2 >= 90)//systole and diastole 
            {
                updatedFiles.Add("*You have a high blood pressure");
            }
            if (res <= 80 | res2 <= 60)
            {
                updatedFiles.Add("*You have a low blood pressure");
            }
            if (res3 > 100)//heart rate
            {
                updatedFiles.Add("*Your Heart Rate is too high");
            }
            if (res3 < 60)
            {
                updatedFiles.Add("Your Heart Rate is too slow");
            }
            if (res4 == 75 || res4 <= 100)
            {
                updatedFiles.Add("Having a low oxygen saturation indicates a lot of serious health problems , you should go to the hospital ASAP");
            }

            if (res <= 120 && res2 <= 80 && res >= 90 && res2 >= 70 && res3 <= 100 && res3 >= 60 && res4 >= 95)
            {
                this.Hide();
                medcert_screen form4 = new medcert_screen();
                form4.ShowDialog();
            }

            else 
            {
                updatedFiles.Add("Wait 10 mins to 15 mins before testing again");
            }
          

            
            if (updatedFiles.Count > 0)
                MessageBox.Show(string.Join("\r\n", updatedFiles));
            
        }

        private void bp_label_Click(object sender, EventArgs e)
        {

        }

        private void tests_Load(object sender, EventArgs e)
        {
           

        }

        private void bp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void hr_TextChanged(object sender, EventArgs e)
        {

        }

        private void o2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void bp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void hr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void o2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
