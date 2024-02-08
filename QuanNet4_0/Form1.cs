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
            //SendData.ws.Connect();
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

                Thread thread = new Thread(() =>
                {
                    SendData.SendAccountToServer(data, TYPE, this);
                });

                thread.Start();

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Language.yesNoTurnOff[Language.languageUsing], Language.notification[Language.languageUsing], MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SendData.ws.Close();
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    Application.Exit();
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

