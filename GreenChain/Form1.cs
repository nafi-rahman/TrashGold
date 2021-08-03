using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;

namespace GreenChain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            guna2Panel1.Height -= 5;

            if (guna2Panel1.Height <= 0)
            {
                timer1.Stop();
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            guna2Panel1.Height -= 5;
            guna2Panel2.Height -= 5;

            if (guna2Panel1.Height <= 0 && guna2Panel2.Height <= 0)
            {
                timer2.Stop();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
