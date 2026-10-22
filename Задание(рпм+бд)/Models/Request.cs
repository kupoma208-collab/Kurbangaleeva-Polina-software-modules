using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_рпм_бд_.Models
{
    public class Request
    {
        public int RequestId;
        public int DeviceId;
        public int ClientId;
        public string Complaint;
        public string Completeness;
        public DateTime DateReceived;
        public DateTime DateClosed;
        public string Status;

        public Device Device;
        public Client Client;
    }
}
