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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1 | textBox2.Text.Length < 1 | textBox3.Text.Length < 1 | textBox4.Text.Length < 1)
            {
                MessageBox.Show("Please fill out all the fields");
                this.Hide();
                tests form43 = new tests();
                form43.ShowDialog();


            }
            string val, val2, val3, val4;
            val = textBox1.Text;
            val2 = textBox2.Text;
            val3 = textBox3.Text;
            val4 = textBox4.Text;

            int res, res2, res3, res4;
            res = Convert.ToInt32(val);
            res2 = Convert.ToInt32(val2);
            res3 = Convert.ToInt32(val3);
            res4 = Convert.ToInt32(val4);


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
               
                updatedFiles.Add("Having a low oxygen saturation indicates a lot of serious health problems, you should go to the hospital ASAP");
            }

            if (res <= 120 && res2 <= 80 && res >= 90 && res2 >= 70 && res3 <= 100 && res3 >= 60 && res4 >= 95)
            {
                this.Hide();
                last_question  form4 = new last_question();
                form4.ShowDialog();
            }
            else
            {
                updatedFiles.Add("Wait 10 to 15 minutes before testing again");
            }


            if (updatedFiles.Count > 0)
                MessageBox.Show(string.Join("\r\n", updatedFiles));
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
