using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_рпм_бд_.Models
{
    public class Model
    {
        public int ModelId;
        public int ManufacturerId;
        public string Name;

        public Manufacturer Manufacturer;
    }
}
