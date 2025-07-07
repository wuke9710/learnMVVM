using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace testBtn
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _message;

        public string Message
        {
            get => _message;
            set
            {
                if (_message != value)
                {
                    _message = value;
                    OnPropertyChanged();
                }
            }
        }

        public RelayCommand ChangeMessageCommand { get; }
        private bool isJishu = false;
        public MainViewModel()
        {
            Message = "Hello, MVVM!";
            ChangeMessageCommand = new RelayCommand(ChangeMessage);
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
