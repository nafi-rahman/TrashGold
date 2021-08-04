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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
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

        

		private void timer3_Tick(object sender, EventArgs e)
		{
            guna2Panel1.Height += 5;
            guna2Panel2.Height += 5;

            if (guna2Panel1.Height >= 573 && guna2Panel2.Height >= 573)
            {
                timer3.Stop();
            }
        }

		private void guna2Button3_Click(object sender, EventArgs e)
		{
            timer3.Start();
        }

		private void guna2Button4_Click(object sender, EventArgs e)
		{
            timer3.Start();
		}

		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
            
            Admin A1 = new Admin();
            A1.ShowDialog();
            this.Show();
            this.Close();
		}
	}
}
