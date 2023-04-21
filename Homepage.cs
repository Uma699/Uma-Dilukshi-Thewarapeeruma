using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKILLS__International_Project
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //page that needed to be load
            Login_Form_1 login_Form_1 = new Login_Form_1();
            login_Form_1.Show();
            this.Hide();

        }

        private void btnregi_Click(object sender, EventArgs e)
        {
            //page that needed to be load
            regist_1 register_1 = new regist_1();
            register_1.Show();
            this.Hide();
        }
    }
}
