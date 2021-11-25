using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace bovid
{
    public partial class id : Form
    {
        registration_screen rs1;
      
        public id()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(36);

            DateTime date = DateTime.Now;

            label8.Text = date.ToShortDateString();
            label10.Text = answer.ToShortDateString();
        }
        public id(registration_screen r1)  
        {
            InitializeComponent();
            this.rs1 = r1;

        }

        private void id_Load(object sender, EventArgs e)
        {

            InitializeComponent();
           
                
            //label8.Text = rs1.textBox1.Text;
            //label10.Text = rs1.textBox2.Text;
 
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void button1_Click_1(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics g = panel.CreateGraphics();
            Size formsize = this.ClientSize;
            bitmap = new Bitmap(formsize.Width - 50, formsize.Height - 75, g);
            g = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            g.CopyFromScreen(panelLocation.X + 80, panelLocation.Y + 30, 85, 80, formsize);
            printPreviewDialog1.ShowDialog();

            PrintPreviewDialog pd = new PrintPreviewDialog();
            printDocument1 doc = new printDocument1();
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("pprnm", 1083, 658);
            //printDocument1.Print();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            return_load next = new return_load();
            this.Hide();
            next.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
 }

