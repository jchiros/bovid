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
    public partial class schedule : Form
    {
        public static schedule instance;
        public schedule()
        {
            InitializeComponent();
            

            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(36);
            

            

            DateTime date = DateTime.Now;
            label6.Text = date.ToShortDateString();









        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Documents\\user_information.accdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();



        private void schedule_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select * from user_details where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'and date2='" + label6.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {
                count++;
            }

            if (count == 1)
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "update user_details set date2='" + "done' where username='"+textBox1.Text+"'and password='"+textBox2.Text+"'";
                command.CommandText = query;
                MessageBox.Show(query);
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                string query1 = "update user_details set date1='" + "done' where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                command.CommandText = query1;
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                MessageBox.Show("Update successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();





                MessageBox.Show("Congratulations you are now officially fully vaccinated!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                dose form56 = new dose();
                form56.ShowDialog();

            }
            else
            {
                MessageBox.Show("Either Username/Password is incorrect or it's not yet the schedule for your 2nd dose", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            connection.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
