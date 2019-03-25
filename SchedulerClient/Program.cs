using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Com.Persagy.Grpc;
using TaskClient;

namespace SchedulerClient
{
    class Program
    {
        /// <summary>
        /// 跟java服务器Socket直连 (server 使用的ObjectOutputStream, 即带有一定格式)
        /// </summary>
        /// <param name="args"></param>
        static void Main1(string[] args)
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
            Socket clientSocket = client.Client;
            //while (true)
            //{
            //    string recStr = "";
            //    byte[] recBytes = new byte[4096];
            //    int bytes = clientSocket.Receive(recBytes, recBytes.Length, 0);
            //    recStr += Encoding.UTF8.GetString(recBytes, 0, bytes);
            //    Console.WriteLine(recStr);
            //}
            NetworkStream stream = client.GetStream();
            StreamReader sr = new StreamReader(stream);
            StreamWriter sw = new StreamWriter(stream);
            short x1 = -21267, x2 = 5;
            Message msg = new Message(sr, sw, clientSocket);
            msg.sendMessage(x1, x2);
            for (int i = 0; i < 10; ++i) {
                Thread.Sleep(3000);
                msg.sendMessage("hello from client.");
                Console.WriteLine("sent");
            }
            Thread.Sleep(1900000);

            // 完成版
            //while (true) {
            //    Console.WriteLine(msg.getMessage());
            //}
            // 测试版
            //while (true)
            //{
            //    //string result = sr.ReadLine();
            //    //Console.WriteLine("read: " + result);
            //    int len = 6;// clientSocket.Available;
            //    if (len == 0)
            //        continue;
            //    char[] chars = new char[len];
            //    int result = sr.Read(chars, 0, len);

            //    if (result > -1)
            //    {
            //        byte[] bytes = Encoding.UTF8.GetBytes(chars, 0, len);
            //        string str = Encoding.UTF8.GetString(bytes);
            //        Console.WriteLine("read: " + str);
            //    }
            //}.

            
        }
        /// <summary>
        /// 使用grpc
        /// </summary>
        /// <param name="args"></param>
        static void Main2(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:6666", ChannelCredentials.Insecure);
            var client = new HelloGRPC.HelloGRPCClient(channel);
            
            HelloRequest hr = new HelloRequest();//创建对象
            hr.Name = "hello from client";

            var reply = client.SayHello(hr);//调用接口，传入对象

            Console.WriteLine(reply.Msg);
            channel.ShutdownAsync().Wait(); 

        }
        static void Main(string[] args)
        {
            //获取Configuration对象
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //根据Key读取<add>元素的Value
            string serverIP = config.AppSettings.Settings["serverIP"].Value;
            //写入<add>元素的Value
            int serverPort = int.Parse(config.AppSettings.Settings["serverPort"].Value);
            string mysqlStr = config.AppSettings.Settings["mysqlConnectString"].Value;

            TaskNettyClient client = new TaskNettyClient(serverIP, serverPort);
            client.RunClientAsync().Wait();

        }

    }
}
