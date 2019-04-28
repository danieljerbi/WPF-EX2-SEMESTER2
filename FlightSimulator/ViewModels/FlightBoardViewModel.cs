using FlightSimulator.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Views.Windows;
using System.Windows.Input;
using FlightSimulator.Model;
using System.ComponentModel;

namespace FlightSimulator.ViewModels
{
    public class FlightBoardViewModel : BaseNotify
    {
        private FlightBoardModel flightBoardModel = new FlightBoardModel(new Info());
        public FlightBoardViewModel()
        {
            flightBoardModel.PropertyChanged += delegate (Object sender, PropertyChangedEventArgs e)
            {
                if (e.PropertyName == "Lat")
                {
                    Lat = flightBoardModel.Lat;
                }
                else if(e.PropertyName == "Lon")
                {
                    Lon = flightBoardModel.Lon;
                }
                NotifyPropertyChanged(e.PropertyName);
            };
        }

        public double Lon { get; set; }
        public double Lat { get; set; }

        private ICommand _settingsCommand; // Settings command for settings button
        public ICommand SettingsCommand
        {
            get
            {
                return _settingsCommand ?? (_settingsCommand = new CommandHandler(() => SettingsClick()));
            }
        }
        void SettingsClick()
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private ICommand _connectCommand; // Settings command for settings button
        public ICommand ConnectCommand
        {
            get
            {
                return _connectCommand ?? (_connectCommand = new CommandHandler(() => ConnectClick()));
            }
        }
        void ConnectClick()
        {
            flightBoardModel.StartReading();
            Commands.Instance.ConnectClient();
        }
    }
}
