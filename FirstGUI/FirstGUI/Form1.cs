using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string UserName = "fast";
        string Password = "fast123";
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUserName.Text==UserName && textBoxPassword.Text==Password)
            {
                HomePage homePage = new HomePage();
                this.Hide();
                homePage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter correct UserName or Password", "Invalid Credential", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
