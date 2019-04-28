using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightSimulator
{
    public class Info
    {
        private TcpListener listener;
        private TcpClient client;
        BinaryReader reader;
        public void Connect()
        {
            listener = new TcpListener(new IPEndPoint(IPAddress.Parse(ApplicationSettingsModel.Instance.FlightServerIP), ApplicationSettingsModel.Instance.FlightInfoPort));
            listener.Start();
            client = listener.AcceptTcpClient();
        }
        public string[] Read()
        {
            NetworkStream stream = client.GetStream();
            reader = new BinaryReader(stream);
            string[] lonAndLat = new string[2];
            char c;
            string str = "";
            try
            {
                while ((c = reader.ReadChar()) != '\n')
                {
                    str = str + c;
                }
                string[] values = str.Split(',');
                lonAndLat[0] = values[0];
                lonAndLat[1] = values[1];
                return lonAndLat;
            }
            catch
            {
            }
            return null;
        }

        #region Singleton
        private static Info m_Instance = null;
        public static Info Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new Info();
                }
                return m_Instance;
            }
        }
        #endregion
    }
}
        
       