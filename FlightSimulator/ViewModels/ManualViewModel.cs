using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.ViewModels
{
    class ManualViewModel
    {
        private ManualModel manualModel = new ManualModel();
        private readonly string throttleSetCommand = "set /controls/engines/current-engine/throttle ";
        private readonly string ruddereSetCommand = "set /controls/flight/rudder ";
        private readonly string aileronSetCommand = "set /controls/flight/aileron ";
        private readonly string elevatorSetCommand = "set /controls/flight/elevator ";
        public double Throttle
        {
            set => manualModel.SendCommand(throttleSetCommand + Convert.ToString(value));
        }
        public double Rudder
        {
            set => manualModel.SendCommand(ruddereSetCommand + Convert.ToString(value));
        }
        public double Aileron
        {
            set => manualModel.SendCommand(aileronSetCommand + Convert.ToString(value));
        }
        public double Elevator
        {
            set => manualModel.SendCommand(elevatorSetCommand + Convert.ToString(value));
        }
    }
}
