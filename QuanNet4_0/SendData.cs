using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
                while (true)
                {
                    byte[] responseData = new byte[1024];
                    int bytesRead = stream.Read(responseData, 0, responseData.Length);
                    string response = Encoding.UTF8.GetString(responseData, 0, bytesRead);
                    Console.WriteLine("Result: " + response);
                    client.Close();
                    break;
                }
            }
            catch
            {
                MessageBox.Show(Language.cannotConnectToServer[Language.languageUsing], Language.notification[Language.languageUsing]);

            }
        }
    }
    
}
