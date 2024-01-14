using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNet4_0
{
    internal class Process
    {
        public static void ProcessReceiveData(string data)
        {
            string[] str = data.Split('|');
            int type = int.Parse(str[str.Length - 1]);
            switch (type)
            {
                case 0:
                    if (int.Parse(str[0]) == 0)
                    {
                        MessageBox.Show(Language.loginSucessful[Language.languageUsing], Language.notification[Language.languageUsing]);
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
            }

        }
    }
}
