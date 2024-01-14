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
        public static void SendAccountToServer(string[] a, int type)
        {
            try
            {
                TcpClient client = new TcpClient("localhost", 8080);
                NetworkStream stream = client.GetStream();
                string extract = string.Empty;
                for (int i = 0;i<a.Length;i++)
                {
                    extract += a[i] + "|";    
                }
                extract += type.ToString();
                byte[] data = Encoding.UTF8.GetBytes(extract);
                stream.Write(data, 0, data.Length);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                while (stopwatch.Elapsed.TotalSeconds < 8)
                {
                    byte[] responseData = new byte[1024];
                    int bytesRead = stream.Read(responseData, 0, responseData.Length);
                    string response = Encoding.UTF8.GetString(responseData, 0, bytesRead);
                    Console.WriteLine("Result: " +  response);
                    Process.ProcessReceiveData(response);                
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
