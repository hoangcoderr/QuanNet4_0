﻿using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace QuanNet4_0
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
            LoadLanguageLogin();
            languageCb.SelectedIndex = 0;
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]

        static extern bool AllocConsole();
        static bool IsInputValid(string username, string password)
        {
            // Kiểm tra xem cả hai ô đều không bị bỏ trống
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }
        public static int TYPE = 0;
        private void LoadLanguageLogin()
        {
            lbLogin.Text = Language.loginText[Language.languageUsing];
            lbUsername.Text = Language.usernameText[Language.languageUsing];
            lbPassword.Text = Language.passwordText[Language.languageUsing];
            createAccBt.Text = Language.createAcc[Language.languageUsing];
            ckbIsShowPassword.Text = Language.showPasswordText[Language.languageUsing];
            lbLanguage.Text = Language.languages[Language.languageUsing];
        }
        private void loginBt_Click(object sender, EventArgs e)
        {
            if (!IsInputValid(usernameTxt.Text, passwordTxt.Text))
            {
                MessageBox.Show(Language.isFilledAccOrPass[Language.languageUsing], Language.notification[Language.languageUsing]);
            }
            else
            {
                string[] data = { usernameTxt.Text, passwordTxt.Text };
                SendData.SendAccountToServer(data, TYPE);
            }
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }


        private void languageCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Language.languageUsing = languageCb.SelectedIndex;
            LoadLanguageLogin();
        }

        private void usernameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void createAccBt_Click(object sender, EventArgs e)
        {
            RegisterAccount registerAccount = new RegisterAccount();
            registerAccount.Show();
        }

        private void ckbIsShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = !ckbIsShowPassword.Checked;
        }
    }
}

