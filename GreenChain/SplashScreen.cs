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
using System.Configuration;
using System.Data.SqlClient;

namespace GreenChain
{
    

    public partial class SplashScreen : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
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
            if (guna2TextBox1.Text != "" && guna2TextBox2.Text != "")
            {

                SqlConnection con = new SqlConnection(cs);
                string query = "select * from REG_TBL WHERE USERNAME=@name and PASS=@pass ";
                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@name", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@pass", guna2TextBox2.Text);
                

                con.Open();
                SqlDataReader dread = cmd.ExecuteReader();

                
                
                    

                    if (dread.HasRows == true)
                    {
                    
                       
                        Admin A1 = new Admin();
                        A1.ShowDialog();
                        this.Show();
                        this.Close();
                   
                    }
                    

                    else
                    {
                        MessageBox.Show("Login Failed", "FAIL");
                    }
                
               

                
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter your valid username and password repectfully", "FAIL");
            }
            
		}

		private void guna2TextBox1_Leave(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(guna2TextBox1.Text) == true)
            {
                guna2TextBox1.Focus();
                errorProvider1.SetError(this.guna2TextBox1, "Please enter a valid username");
            }
            else {
                errorProvider1.Clear();
            }
		}

		private void guna2TextBox2_Leave(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(guna2TextBox2.Text) == true)
            {
                guna2TextBox2.Focus();
                errorProvider2.SetError(this.guna2TextBox2, "Please enter a valid password");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
        private void guna2ToggleSwitch1_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip1.Show("toggle to view password", guna2ToggleSwitch1);
        }
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
		{
            bool stat = guna2ToggleSwitch1.Checked;
 
            switch (stat)
            {
 
                case true:
                    guna2TextBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    guna2TextBox2.UseSystemPasswordChar = true;
                    break;
            }
		}

		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into REG_TBL VALUES (@type,@name,@email,@pass)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@email", guna2TextBox4.Text);
            cmd.Parameters.AddWithValue("@pass", guna2TextBox6.Text);
            cmd.Parameters.AddWithValue("@type", guna2ComboBox1.Text);


            con.Open();
            int a  = cmd.ExecuteNonQuery();





            if (a>0)
            {

                MessageBox.Show("inserted");

            }


            else
            {
                MessageBox.Show("not");
            }




            con.Close();
        }
	}
}
