using Client1.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client1.ViewModel
{
    public class ClientViewModel : BaseViewModel
    {
       public SendCommand sendCommandCMD { get; set; }
        public Socket socket;
        public ClientViewModel()
        {
            sendCommandCMD = new SendCommand(this);
            IPEndPoint ıPEndPoint = new IPEndPoint(IPAddress.Parse("10.1.16.13"), 1031);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ıPEndPoint);
        }
        private string client;
        public string Client
        {

            get
            {
                return client;
            }
            set
            {
                client = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof (Client)));
            }
        }
        string currentText;
        public string CurrentText
         {
            get
            {
                return currentText;
            }

            set
            {
                currentText = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentText)));
            }

        }

    }
}
