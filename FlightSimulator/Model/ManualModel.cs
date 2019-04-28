using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightSimulator.Model
{
    public class ManualModel
    {
        public void SendCommand(string command)
        {
            if (Commands.Instance.Connected)
            {
                new Thread(delegate ()
                {
                    Commands.Instance.Write(command);
                }).Start();
            }
        }
    }
}
