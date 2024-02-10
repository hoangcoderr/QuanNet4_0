using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanNet4_0
{
    internal class Process
    {

        public static void ProcessReceiveData(Form1 form, string data)
        {
            string[] str = data.Split('|');
            int type = int.Parse(str[str.Length - 1]);
            switch (type)
            {
                case 0:
                    if (int.Parse(str[0]) == 0)
                    {
                        form.Invoke((MethodInvoker)delegate
                        {
                            form.Hide();
                        });
                        MessageBox.Show(Language.loginSucessful[Language.languageUsing], Language.notification[Language.languageUsing]);

                        MainClient mainClient = new MainClient(str[2], str[3], int.Parse(str[4]));

                        Application.Run(mainClient);

                    }

                    else
                    {
                        MessageBox.Show(Language.wrongInformationText[Language.languageUsing], Language.notification[Language.languageUsing]);
                    }
                    break;
                case 1:
                    if (int.Parse(str[0]) == 0)
                    {
                        MessageBox.Show(Language.registerSucessful[Language.languageUsing], Language.notification[Language.languageUsing]);
                    }
                    else
                    {
                        MessageBox.Show(Language.isAvaiableAccount[Language.languageUsing], Language.notification[Language.languageUsing]);
                    }
                    break;
                case 2:
                    if (int.Parse(str[0]) == 1)
                    {
                        MessageBox.Show(Language.notEnoughMoney[Language.languageUsing], Language.notEnoughMoney[Language.languageUsing]);
                    }
                    else if (int.Parse(str[0]) == 0)
                    {
                        MainClient.amount -= int.Parse(str[1]);
                        MessageBox.Show(Language.buySucessfully[Language.languageUsing], Language.buySucessfully[Language.languageUsing]);
                        MainClient mainClientForm = Application.OpenForms.OfType<MainClient>().FirstOrDefault();
                        if (mainClientForm != null)
                        {
                            mainClientForm.UpdateAmount(MainClient.amount);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Language.notEnoughItemFromServer[Language.languageUsing], Language.notification[Language.languageUsing]);
                    }
                    break;
            }

        }
    }
}
