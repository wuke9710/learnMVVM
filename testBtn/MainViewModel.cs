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
        public RelayCommand SecondMessageCommand { get; }
        private bool isJishu = false;
        private bool OisJishu = false;
        public MainViewModel()
        {
            Message = "Hello, MVVM!";
            OtherMessage = "Hello, Other!";
            ChangeMessageCommand = new RelayCommand(ChangeMessage);
            SecondMessageCommand = new RelayCommand(OtherChangeMessage);
        }

        private void ChangeMessage()
        {
            if (!isJishu)
            {
                Message = "Message changed!";
                isJishu = true;
            }
            else
            {
                Message = "Hello, MVVM!";
                isJishu = false;
            }
        }
        private void OtherChangeMessage()
        {
            if (!OisJishu)
            {
                OtherMessage = "Other changed!";
                OisJishu = true;
            }
            else
            {
                OtherMessage = "Hello, Other!";
                OisJishu = false;
            }
        }
    }
}
