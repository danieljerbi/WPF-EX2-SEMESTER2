using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.Model
{
    public class AutoModel
    {
        public void SendCommands(string input)
        {
            if (Commands.Instance.Connected)
            {
                new Task(delegate ()
                {
                    Commands.Instance.Write(input);
                }).Start();
            }

        }
    }
}
