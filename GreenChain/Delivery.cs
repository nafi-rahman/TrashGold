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
	public partial class Delivery : Form
	{
		public void hidepanel()
		{
			order.Visible = false;
			history.Visible = false;
			payment.Visible = false;
		}
		public Delivery()
		{
			InitializeComponent();
		}

		private void guna2Button6_Click(object sender, EventArgs e)
		{

		}

		private void order_Click(object sender, EventArgs e)
		{
			hidepanel();
			order.Visible = true;
		
		}

		private void history_Click(object sender, EventArgs e)
		{
			hidepanel();
			history.Visible = true;
		}

		private void payment_Click(object sender, EventArgs e)
		{
			hidepanel();
			payment.Visible = true;
		}
	}
}
