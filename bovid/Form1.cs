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
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();



        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\CODE FOR MODSIM (11-23-21)\\user_information.accdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            label3.Text = date.ToShortDateString();


            connection.Open();

            command.Connection = connection;
            command.CommandText = "select * from user_details where username='" + txtboxUsername.Text + "'and password='" + txtboxPassword.Text + "'and date2='" + label3.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();


            int count = 0;

            while (reader.Read())
            {
                count++;
            }

            if (count == 1)
            {
                MessageBox.Show("Username and Password is correct", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



                this.Hide();
                waiver form2 = new waiver();
                form2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Either Username/Password is incorrect or it's not yet the schedule for your 2nd dose", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration_screen form6 = new registration_screen();
            form6.ShowDialog();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {
            //txtboxPassword.PasswordChar = '*';

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            questions form89 = new questions();
            form89.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            tests form78 = new tests();
            form78.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            last_question form783 = new last_question();
            form783.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            observation_and_final_checks form12 = new observation_and_final_checks();
            form12.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtboxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtboxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
