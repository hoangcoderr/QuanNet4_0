using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            lbName.Text = Language.nameText[l];
        }
        public bool isFilled()
        {
            if (string.IsNullOrEmpty(txtUserRegister.Text) ||
                string.IsNullOrEmpty(txtPassRegister.Text) ||
                string.IsNullOrEmpty(txtRetypePassRegister.Text)||
                string.IsNullOrEmpty(txtName.Text))
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
                string[] data = { txtUserRegister.Text, txtPassRegister.Text,txtName.Text };
                SendData.SendAccountToServer(data, TYPE);
            }
        }

        private void ckbIsShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassRegister.UseSystemPasswordChar = !ckbIsShowPassword.Checked;
            txtRetypePassRegister.UseSystemPasswordChar = !ckbIsShowPassword.Checked;
        }

        private void txtUserRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
