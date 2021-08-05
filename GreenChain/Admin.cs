using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenChain
{
	public partial class Admin : Form
	{

		public void hidepanel() { 
			userpanel.Visible = false;
			compostePanel.Visible = false;
			deliveryPanel.Visible = false;
			activityPanel.Visible = false;
			

		}
		public Admin()
		{
			InitializeComponent();
			
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{

		}

		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void guna2Button6_Click(object sender, EventArgs e)
		{
			this.Close();
			SplashScreen s = new SplashScreen();
			
			s.ShowDialog();
			this.Show();
		}

		private void guna2HtmlLabel2_Click(object sender, EventArgs e)
		{

		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			hidepanel();
			userpanel.Visible = true;
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			hidepanel();
			compostePanel.Visible = true;

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			 
		}

		private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void guna2Button4_Click(object sender, EventArgs e)
		{
			hidepanel();
			deliveryPanel.Visible = true;
		}

		private void guna2Button5_Click(object sender, EventArgs e)
		{
			hidepanel();
			activityPanel.Visible = true;
		}

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			guna2GradientPanel1.Width -= 5;
			

			if (guna2GradientPanel1.Width <= 0 )
			{
				timer1.Stop();
			}
		}

		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void guna2HtmlLabel3_Click(object sender, EventArgs e)
		{

		}

		private void guna2HtmlLabel8_Click(object sender, EventArgs e)
		{

		}

		private void guna2HtmlLabel13_Click(object sender, EventArgs e)
		{

		}
	}
}
