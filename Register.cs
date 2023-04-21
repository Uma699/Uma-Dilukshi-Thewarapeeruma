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
    public partial class regist_1 : Form
    {
        public regist_1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BCMT7TV\UMADILUKSHI;Initial Catalog=Student;Integrated Security=True");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string no = cmbReg.Text;
            if (no != "New Register")
            {
                string fisrtName = txtfname.Text;
                string lastName = txtLname.Text;
                dtpDob.Format = DateTimePickerFormat.Custom;
                dtpDob.CustomFormat = "yyyy/mm/dd";
                string gender;
                if (rbMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                String address = txtAddress.Text;
                String email = txtEmail.Text;
                int mobilephone = int.Parse(txtMobile.Text);
                int homephone = int.Parse(txtHphone.Text);
                string parentsname = txtPName.Text;
                string NIC = txtnic.Text;
                int contactNumber = int.Parse(txtCnumber.Text);

                string query_insert = "UPDATE students SET fisrtName = '" + fisrtName + "',lastName ='" + lastName + "',dateOfBirth = '" + dtpDob.Text + "',gender= '" + gender + "',address = '" + address + "',email = '" + email + "',mobilephon = '" + mobilephone + "',homephone = '" + homephone + "',parentsname = '" + parentsname + "',NIC = '" + NIC + "',contactNumber = '" + contactNumber + ")";

                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);

                cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Succesfully !", "Registered Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnRegi2_Click(object sender, EventArgs e)
        {
            try
            {
                string fisrtName = txtfname.Text;
                string lastName = txtLname.Text;
                dtpDob.Format = DateTimePickerFormat.Custom;
                dtpDob.CustomFormat = "yyyy/mm/dd";
                string gender;
                if (rbMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                String address = txtAddress.Text;
                String email = txtEmail.Text;
                int mobilephone = int.Parse(txtMobile.Text);
                int homephone = int.Parse(txtHphone.Text);
                string parentsname = txtPName.Text;
                string NIC = txtnic.Text;
                int contactNumber = int.Parse(txtCnumber.Text);
                string query_insert = "insert into students values('" + fisrtName + "','" + lastName + "','" + dtpDob.Text + "','" + gender + "','" + address + "','" + email + "','" + mobilephone + "','" + homephone + "','" + parentsname + "','" + NIC + "','" + contactNumber")";


                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);

                cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Succesfully !", "Registered Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                string msg = "insert Error:";
                msg += ex.Message;

            }

        }

        private void btnclear2_Click(object sender, EventArgs e)
        {
                cmbReg.Text = "";
                txtfname.Text = "";
                txtLname.Text = "";
                dtpDob.Format = DateTimePickerFormat.Custom;
                dtpDob.CustomFormat = "yyyy/mmm/ddd";
                DateTime thisday = DateTime.Today;
                dtpDob.Text = thisday.ToString();

                rbMale.Checked = false;
                rbfemale.Checked = false;
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtMobile.Text = "";
                txtHphone.Text = "";
                txtPName.Text = "";
                txtnic.Text = "";
                txtCnumber.Text = "";

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            {
                var result = MessageBox.Show(" Are you sure, Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                 string no = cmbReg.Text;

                 string query_insert = "DELETE FROM student WHERE regNo = " + no + "";
                 con.Open();
                 SqlCommand cmnd = new SqlCommand(query_insert, con);
                 cmnd.ExecuteNonQuery();
                 con.Close();
                 MessageBox.Show("Record Deleted Successfully!", "Deleted Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (result ==DialogResult.Yes)
                {
                 this.Close();
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Homepage obj = new Homepage();
            obj.Show();
            this.Close();
        }

        private void Labexit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void cmbReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query_select = "Select * FROM student";
            SqlCommand cmnd = new SqlCommand(query_select, con);
            SqlDataReader row = cmnd.ExecuteReader();
            cmbReg.Items.Add("New Register");
            while (row.Read())
            {
                cmbReg.Items.Add(row[0].ToString());
            }
            con.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
           
        }

        private void Register_Load(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show(" Are you sure, Do you really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
