using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanNet4_0
{
    public partial class MainClient : Form
    {
        public static string username;
        public static string name;
        public static int amount;
        public MainClient(string account, string name, int amount)
        {
            InitializeComponent();
            loadLanguageMainClient();
            LoadInfomationUser(account, name, amount);
        }
        public void LoadInfomationUser(string account, string name, int amount)
        {
            username = account;
            MainClient.name = name;
            MainClient.amount = amount;
            amount *= 1000;
            lbAmountNumber.Text = amount.ToString("N0") + " VND";
            lbName.Text = name;
            lbAmountNumber.Left = this.ClientSize.Width - lbAmountNumber.Width;
            lbAmount.Location = new Point(lbAmountNumber.Location.X - lbAmount.Size.Width, lbAmountNumber.Location.Y);
            lbName.Location = new Point(lbAmount.Location.X - lbName.Size.Width, lbAmount.Location.Y);
            lbWelcome.Location = new Point(lbName.Location.X - lbWelcome.Size.Width, lbWelcome.Location.Y);
        }
        public void UpdateAmount(int newAmount)
        {
            MainClient.amount = newAmount;
            int displayedAmount = amount * 1000; // Chuyển đổi sang đơn vị VND

            // Sử dụng Invoke để thực hiện cập nhật trên luồng chính
            if (lbAmountNumber.InvokeRequired)
            {
                lbAmountNumber.Invoke(new MethodInvoker(delegate {
                    lbAmountNumber.Text = displayedAmount.ToString("N0") + " VND";
                }));
            }
            else
            {
                lbAmountNumber.Text = displayedAmount.ToString("N0") + " VND";
            }
        }
        private void loadLanguageMainClient()
        {
            lbWelcome.Text = Language.welcomeText[Language.languageUsing];
            lbAmount.Text = Language.amountText[Language.languageUsing];
        }
        private void lbAmount_Click(object sender, EventArgs e)
        {

        }

        private void MainClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainClient_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BTTEST_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Tested");
            string[] sendData = {username, "5", };
            SendData.SendDataToServer(sendData, 2);
        }
    }
}
