using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace testBtn
{
    public class MainViewModel : NotifyPropertyObject
    {
        private string _message;
        private string _Othermessage;

        public string Message
        {
            get => _message;
            set
            {
                if (_message != value)
                {
                    _message = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string OtherMessage
        {
            get => _Othermessage;
            set
            {
                if (_Othermessage != value)
                {
                    _Othermessage = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public RelayCommand ChangeMessageCommand { get; }
        public RelayCommand MouserOverCommand { get; }
        public RelayCommand MouserClickCommand { get; }

        public MainViewModel()
        {
            Message = "Hello, MVVM!";
            OtherMessage = "Hello, Other!";
            ChangeMessageCommand = new RelayCommand(ChangeMessage);
            MouserOverCommand = new RelayCommand(MouserOverChange);
            MouserClickCommand = new RelayCommand(MouserClickChange);
        }

        private void ChangeMessage()
        {
            int second = DateTime.Now.Second;
            if (second % 2 == 0)
            {
                Message = "Message changed!";
            }
            else
            {
                Message = "Hello, MVVM!";
            }
        }
        private void MouserOverChange()
        {
            int second = DateTime.Now.Second;

            if (second % 2 == 0)
            {
                OtherMessage = "over changed oushu!";
            }
            else
            {
                OtherMessage = "over changed jishu!";
            }
        }
        private void MouserClickChange()
        {
            int second = DateTime.Now.Second;

            if (second % 2 == 0)
            {
                OtherMessage = "click changed oushu!";
            }
            else
            {
                OtherMessage = "click changed jishu!";
            }
        }
    }
}
