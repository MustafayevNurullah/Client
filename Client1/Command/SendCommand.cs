using Client1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Client1.Command
{
    public class SendCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        ClientViewModel clientViewModel;
        public SendCommand(ClientViewModel clientViewModel)
        {
            this.clientViewModel = clientViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Task senderTask = Task.Run(() =>
            {
                clientViewModel.socket.Send(Encoding.ASCII.GetBytes(clientViewModel.CurrentText));

            });
        }
    }
}
