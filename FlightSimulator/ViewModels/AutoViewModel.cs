using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace FlightSimulator.ViewModels
{
    class AutoViewModel : BaseNotify
    {
        private AutoModel autoModel = new AutoModel();
        private Brush background = Brushes.White; // Background color
        private string commands;
        public Brush Background
        {
            get
            {
                return background;
            }
            set
            {
                background = value;
                NotifyPropertyChanged("Background");
            }

        }
        public string Commands
        {
            get { return commands; }

            set
            {
                commands = value;
                Background = Brushes.LightPink;
                if (string.IsNullOrEmpty(Commands))
                {
                    Background = Brushes.White;
                }
                NotifyPropertyChanged("Commands");
            }
        }
        private ICommand _okCommand;
        public ICommand OkCommand
        {
            get
            {
                return _okCommand ?? (_okCommand = new CommandHandler(() => OkClick()));
            }
        }
        void OkClick()
        {
            autoModel.SendCommands(commands);
            Background = Brushes.White;
            Commands = "";
        }

        private ICommand _clearCommand;
        public ICommand ClearCommand
        {
            get
            {
                return _clearCommand ?? (_clearCommand = new CommandHandler(() => ClearClick()));
            }
        }
        void ClearClick()
        {
            Background = Brushes.White;
            Commands = "";
        }
    }
}
