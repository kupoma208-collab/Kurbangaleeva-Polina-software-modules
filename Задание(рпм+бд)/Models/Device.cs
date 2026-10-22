using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_рпм_бд_.Models
{
    public class Device
    {
        public int DeviceId;
        public int ModelId;
        public string AccountNumber;
        public string SerialNumber;

        public Model Model;
    }
}
