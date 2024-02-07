using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanNet4_0
{
    public partial class MainClient : Form
    {
        public MainClient(string account, string name, int amount)
        {
            InitializeComponent();
            loadLanguageMainClient();
            LoadInfomationUser(account, name, amount);  
        }
        public void LoadInfomationUser(string account, string name, int amount)
        {
            amount *= 1000;
            lbAmountNumber.Text = amount.ToString("N0") + " VND";
            lbName.Text = name;
            lbAmountNumber.Left = this.ClientSize.Width - lbAmountNumber.Width;
            lbAmount.Location = new Point(lbAmountNumber.Location.X - lbAmount.Size.Width, lbAmountNumber.Location.Y);
            lbName.Location = new Point(lbAmount.Location.X - lbName.Size.Width, lbAmount.Location.Y);
            lbWelcome.Location = new Point(lbName.Location.X - lbWelcome.Size.Width, lbWelcome.Location.Y);
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
            
        }
    }
}
