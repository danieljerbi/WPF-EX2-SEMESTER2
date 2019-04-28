using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FlightSimulator.Model;

namespace FlightSimulator
{
    class Commands
    {
        private IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ApplicationSettingsModel.Instance.FlightServerIP), ApplicationSettingsModel.Instance.FlightCommandPort);
        private TcpClient client = new TcpClient();
        BinaryWriter writer;
        public bool Connected { get; set; } = false; 

        #region Singleton
        private static Commands m_Instance = null;
        public static Commands Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new Commands();
                }
                return m_Instance;
            }
        }
        #endregion
        public void Client()
        {
            while (!client.Connected)
            {
                try
                {
                    client.Connect(ep);
                }
                catch(Exception)
                {
                }
            }
            Connected = true;
            NetworkStream stream = client.GetStream();
            writer = new BinaryWriter(stream);
        }
        public void ConnectClient()
        {
            Thread thread = new Thread(new ThreadStart(Client));
            thread.Start();
        }
        public void Write(string message)
        {
            string[] commands = message.Split('\n');
            foreach (string command in commands)
            {
                string set = command + "\r\n";
                writer.Write(System.Text.Encoding.ASCII.GetBytes(set));
                System.Threading.Thread.Sleep(2000);
            }

        }
    }
}
