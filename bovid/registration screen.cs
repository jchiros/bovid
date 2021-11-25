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
    public partial class registration_screen : Form
    {
        
        public registration_screen()
        {
            InitializeComponent();
         
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\CODE FOR MODSIM (11-23-21)\\user_information.accdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();
        private void registration_screen_Load(object sender, EventArgs e)
        {
           // _1st_dose d1 = new _1st_dose();
            //d1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 1 | textBox4.Text.Length < 1 | textBox1.Text.Length < 1 | textBox2.Text.Length < 1)
            {
                MessageBox.Show("Please fill out all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                registration_screen form67 = new registration_screen();
                form67.ShowDialog();
                id f2 = new id(this);
                f2.ShowDialog();


            }
            else
            {
                connection.Open();


                command.Connection = connection;
                command.CommandText = "select * from user_details where username='" + textBox3.Text + "' or fullname = '" + textBox1.Text + "' or contactnumber = '" + textBox2.Text + "'";
    


                OleDbDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count++;
                }

                if (count == 1 || count == 3 || count == 4)
                {


                    MessageBox.Show("Name, Contact number or Username already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                    registration_screen form1 = new registration_screen();
                    form1.ShowDialog();



                }
                else
                {
                    command.Connection = connection;
                    command = new OleDbCommand("INSERT INTO user_details([username],[password],[fullname],[contactnumber],[date2]) values(@username,@password,@fullname,@contactnumber,@date2)", connection);
                    command.Parameters.AddWithValue("@username", textBox3.Text);
                    command.Parameters.AddWithValue("@password", textBox4.Text);
                    command.Parameters.AddWithValue("@fullname", textBox1.Text);
                    command.Parameters.AddWithValue("@contactnumber", textBox2.Text);
                    command.Parameters.AddWithValue("@date2", "empty");

                    command.ExecuteNonQuery();



                    connection.Close();

                    MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    waiver form7 = new waiver();
                    form7.ShowDialog();


                }



            }





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar!= '.')
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (! char.IsDigit(ch)&&ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
