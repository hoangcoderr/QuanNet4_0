using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QuanNet4_0
{
    internal class SendData
    {
        public static void SendAccountToServer(string a, string b, int type)
        {
            try
            {
                TcpClient client = new TcpClient("localhost", 8080);
                NetworkStream stream = client.GetStream();
                byte[] data = Encoding.UTF8.GetBytes(a + " " + b + " " + type);
                stream.Write(data, 0, data.Length);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                while (stopwatch.Elapsed.TotalSeconds < 8)
                {
                    byte[] responseData = new byte[1024];
                    int bytesRead = stream.Read(responseData, 0, responseData.Length);
                    string response = Encoding.UTF8.GetString(responseData, 0, bytesRead);
                    if (response == "Registered")
                    {
                        MessageBox.Show(Language.isAvaiableAccount[Language.languageUsing], Language.notification[Language.languageUsing]);
                    }
                    else if (response == "Register done") 
                        MessageBox.Show(Language.registerSucessful[Language.languageUsing], Language.notification[Language.languageUsing]);
                    else if (response == "Login sucessful")
                    {
                        MessageBox.Show(Language.loginSucessful[Language.languageUsing], Language.notification[Language.languageUsing]);
                    }
                    else if (response == "Wrong information")
                        MessageBox.Show(Language.wrongInformationText[Language.languageUsing], Language.notification[Language.languageUsing]);
                    client.Close();
                    return;
                }
                MessageBox.Show(Language.cannotConnectToServer[Language.languageUsing], Language.notification[Language.languageUsing]);
            }
            catch
            {
                MessageBox.Show(Language.cannotConnectToServer[Language.languageUsing], Language.notification[Language.languageUsing]);

            }
        }
    }
    
}
