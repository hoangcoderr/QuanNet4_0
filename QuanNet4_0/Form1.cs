using MySql.Data.MySqlClient;
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

        public static string mysqlCon = "server=127.0.0.1; user = root; database = quannet4cham0; passsword =";
        public static DateTime currentTime = DateTime.Now;
        private void LoadLanguageLogin()
        {
            lbLogin.Text = Language.loginText[Language.languageUsing];
            lbUsername.Text = Language.usernameText[Language.languageUsing];
            lbPassword.Text = Language.passwordText[Language.languageUsing];
            createAccBt.Text = Language.createAcc[Language.languageUsing];
            ckbIsShowPassword.Text = Language.showPasswordText[Language.languageUsing];
        }
        private void loginBt_Click(object sender, EventArgs e)
        {
            if (!IsInputValid(usernameTxt.Text, passwordTxt.Text))
            {
                MessageBox.Show(Language.isFilledAccOrPass[Language.languageUsing], Language.notification[Language.languageUsing]);
            }
            else
            {
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
                SqlConnection.sqlConnect(mySqlConnection);
                if (SqlProgession.IsUserAvaiable(mySqlConnection, usernameTxt.Text, passwordTxt.Text))
                {
                    MessageBox.Show(Language.loginSucessful[Language.languageUsing], Language.notification[Language.languageUsing]);
                }
                else
                {

                    MessageBox.Show(Language.wrongInformationText[Language.languageUsing], Language.notification[Language.languageUsing]);
                }
                SqlConnection.sqlClose(mySqlConnection);
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
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
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

