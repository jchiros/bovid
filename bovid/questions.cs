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
    public partial class questions : Form
    {
        

        public questions()
        {
            InitializeComponent();
            label6.Hide();
            checkedListBox6.Hide();
            button1.Enabled = false;
            checkedListBox2.Enabled = false;
            checkedListBox3.Enabled = false;
            checkedListBox4.Enabled = false;
            checkedListBox5.Enabled = false;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Show();
           
         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
               
            }
        

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

       
                this.Hide();
                tests form4 = new tests();
                form4.Show();
            
        }
      

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {


                    checkedListBox1.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
            foreach (int index1 in checkedListBox1.CheckedIndices)
            {
                if (index1 == 0)
                {
                    label6.Show();
                    checkedListBox6.Show();

                    foreach (int index9 in checkedListBox1.CheckedIndices)
                    {
                        if (index9 == 1 && index1 == 0)
                        {

                           

                        }


                    }
                }

                if (index1 == 1)
                {
                    
                    checkedListBox2.Enabled = true;
                    checkedListBox1.Enabled = false;
                }
            }


      }

        private void checkedListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox6.SelectedIndex;
            int count = checkedListBox6.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {


                    checkedListBox6.SetItemCheckState(x, CheckState.Unchecked);


                }
            }
            foreach(int index1 in checkedListBox6.CheckedIndices)
            {
                if (index1 == 0)
                {
                    button1.Enabled = false;
                    MessageBox.Show("The polysorbate 80 is responsible for allergic reactions, people with history of allergy to vaccine compounds(poly80) must be excluded from vaccination");
                    this.Hide();
                    Form1 form12 = new Form1();
                    form12.ShowDialog();
                }

                if (index1 == 1)
                {
                    checkedListBox2.Enabled = true;
                    checkedListBox1.Enabled = false;
                }
               
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox2.SelectedIndex;
            int count = checkedListBox2.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {


                    checkedListBox2.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
            foreach (int index1 in checkedListBox2.CheckedIndices)
            {
                if (index1 == 1)
                {
                   
                    checkedListBox3.Enabled = true;
                    checkedListBox2.Enabled = false;

                }
                if(index1 == 0)
                {
                    button1.Enabled = false;
                    MessageBox.Show("You shouldn't get this vaccine, get one from the same brand of vaccine, if you got a sinovac's 1st dose , you should also get sinovac's 2nd dose");
                    this.Hide();
                    Form1 form12 = new Form1();
                    form12.ShowDialog();
                }
            }
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = checkedListBox3.SelectedIndex;
            int count = checkedListBox3.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {


                    checkedListBox3.SetItemCheckState(x, CheckState.Unchecked);
                }

                foreach (int index1 in checkedListBox3.CheckedIndices)
                {
                    if (index1 == 1)
                    {
                       
                        checkedListBox4.Enabled = true;
                        checkedListBox3.Enabled = false;

                    }
                    if (index1 == 0)
                    {
                        button1.Enabled = false;
                        MessageBox.Show("You should get mRNA type of vaccine, vaccines like moderna and pfizer would be the safest for you");
                        this.Hide();
                        Form1 form12 = new Form1();
                        form12.ShowDialog();
                    }
                }
            }
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox4.SelectedIndex;
            int count = checkedListBox4.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {


                    checkedListBox4.SetItemCheckState(x, CheckState.Unchecked);
                }

                foreach (int index1 in checkedListBox4.CheckedIndices)
                {
                    if (index1 == 1)
                    {
                        
                        checkedListBox5.Enabled = true;
                        checkedListBox4.Enabled = false;

                    }
                    if (index1 == 0)
                    {
                        button1.Enabled = false;
                        MessageBox.Show("Come back 3 months from now");
                        this.Hide();
                        Form1 form12 = new Form1();
                        form12.ShowDialog();
                    }
                }
            }
        }
        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox5.SelectedIndex;
            int count = checkedListBox5.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {


                    checkedListBox5.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
            foreach (int index1 in checkedListBox5.CheckedIndices)
            {
                if (index1 == 1)
                {
                    
                    button1.Enabled = true;
                    checkedListBox5.Enabled = false;

                }
                if(index1 == 0)
                {
                    button1.Enabled = false;
                    MessageBox.Show("Come back in two weeks");
                    this.Hide();
                    Form1 form12 = new Form1();
                    form12.ShowDialog();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void questions_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
