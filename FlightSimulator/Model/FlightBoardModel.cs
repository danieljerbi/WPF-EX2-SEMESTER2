using FlightSimulator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightSimulator.Model
{
    public class FlightBoardModel : BaseNotify
    {
        private Info info;
        private double lon;
        private double lat;

        public FlightBoardModel(Info info)
        {
            this.info = info;
        }
        public void StartReading()
        {
            new Thread(delegate ()
            {
                info.Connect();
                while (true)
                {
                    string[] str = info.Read();
                    if (str != null)
                    {
                        Lon = Convert.ToDouble(str[0]);
                        Lat = Convert.ToDouble(str[1]);
                    }
                }
            }).Start();
        }

        public double Lon
        {
            get
            {
                return lon;
            }
            set
            {
                lon = value;
                NotifyPropertyChanged("Lon");
            }
        }
        public double Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
                NotifyPropertyChanged("Lat");
            }
        }

    }
}
