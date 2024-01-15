using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using WebSocketSharp;

namespace QuanNet4_0
{
    internal class SendData
    {
        public static void SendAccountToServer(string[] a, int type)
        {
            try
            {
                var ws = new WebSocket("ws://localhost:8080/Echo");
                
                    string extract = string.Empty;
                    for (int i = 0; i < a.Length; i++)
                    {
                        extract += a[i] + "|";
                    }
                    extract += type.ToString();
                ws.OnMessage += (sender, e) =>
                {
                    Console.WriteLine("Client received: " + e.Data);
                    string response = e.Data;
                    Process.ProcessReceiveData(response);
                    
                    ws.Close();
                };

                    ws.Connect();
                    ws.Send(extract);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(Language.cannotConnectToServer[Language.languageUsing], Language.notification[Language.languageUsing]);
                Console.WriteLine(ex.ToString());
            }
        }
    }

}
