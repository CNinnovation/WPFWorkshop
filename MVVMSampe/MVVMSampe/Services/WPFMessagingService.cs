using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMSampe.Services
{
    public class WPFMessagingService : IMessagingService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
