using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SKILLS__International_Project
{
    public partial class Login_Form_1 : Form
    {
        public Login_Form_1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BCMT7TV\UMADILUKSHI;Initial Catalog=Student;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            String username, password;

            username = txtUsername.Text;
            password = txtPassword.Text;

            try
            {
                string query = "SELECT * FROM Login_fm WHERE username = '" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    //page that needed to be load
                    Student_Prof Spf = new Student_Prof();
                    Spf.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login Credentials,Please click Username & Password and try again ! ", "Invalid Login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    //to Focus username
                    txtUsername.Focus();
                }

            }
             catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }


            

        }

               
     

        private void Btnclear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

        }

        private void btnexit1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you Sure ,Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
