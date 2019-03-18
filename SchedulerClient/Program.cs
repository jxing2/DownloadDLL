using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerClient
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //获取Configuration对象
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //根据Key读取<add>元素的Value
            string serverIP = config.AppSettings.Settings["serverIP"].Value;
            //写入<add>元素的Value
            int serverPort = int.Parse(config.AppSettings.Settings["serverPort"].Value);
            string mysqlStr = config.AppSettings.Settings["mysqlConnectString"].Value;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            TcpClient client = new TcpClient();
            client.Connect(IPAddress.Parse(serverIP), serverPort);
            NetworkStream stream = client.GetStream();
            
        }
    }
}
