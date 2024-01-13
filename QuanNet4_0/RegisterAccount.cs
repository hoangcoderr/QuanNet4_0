using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanNet4_0
{
    public partial class RegisterAccount : Form
    {
        public RegisterAccount()
        {
            InitializeComponent();
        }
        public static int TYPE = 1;

        private void RegisterAccount_Load(object sender, EventArgs e)
        {
            LoadLanguageRegister();
        }
        public void LoadLanguageRegister()
        {
            int l = Language.languageUsing;
            lbRegister.Text = Language.registerText[l];
            lbPasswordRegister.Text = Language.passwordText[l];
            lbRetypePasswordRegister.Text = Language.retypePasswordText[l];
            lbUserRegister.Text = Language.usernameText[l];
            ckbIsShowPassword.Text = Language.showPasswordText[l];
            btRegister.Text = Language.registerText[l];
        }
        public bool isFilled()
        {
            if (string.IsNullOrEmpty(txtUserRegister.Text) ||
                string.IsNullOrEmpty(txtPassRegister.Text) ||
                string.IsNullOrEmpty(txtRetypePassRegister.Text))
            {
                return false;
            }
            return true;
        }
        public bool isMatchedPassword()
        {
            if (txtPassRegister.Text == txtRetypePassRegister.Text)
            {
                return true;
            }
            return false;
        }

        private void txtRegister_Click(object sender, EventArgs e)
        {
            if (!isFilled())
            {
                MessageBox.Show(Language.isFilledAccOrPass[Language.languageUsing], Language.notification[Language.languageUsing]);
                return;
            }
            else if (!isMatchedPassword())
            {
                MessageBox.Show(Language.isMatchedPassword[Language.languageUsing], Language.notification[Language.languageUsing]);
            }
            else
            {
                SendData.SendAccountToServer(txtUserRegister.Text, txtPassRegister.Text, TYPE);
            }
        }

        private void ckbIsShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassRegister.UseSystemPasswordChar = !ckbIsShowPassword.Checked;
            txtRetypePassRegister.UseSystemPasswordChar= !ckbIsShowPassword.Checked;
        }
    }
}
