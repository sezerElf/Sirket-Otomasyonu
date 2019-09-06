using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassCb_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCb.Checked)
            {
                passwordTb.PasswordChar = '\0';
            }
            else
            {
                passwordTb.PasswordChar = '*';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameTb.Text=="elif" && passwordTb.Text=="123")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre hatalı");
            }
        }
    }
}
