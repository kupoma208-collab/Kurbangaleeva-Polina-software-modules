using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_рпм_бд_.Models
{
    public class CompletedWork
    {
        public int CompletedWorkId;
        public int RequestId;
        public int WorkTypeId;
        public int MasterId;
        public decimal Price;
        public string Result;

        public Request Request;
        public WorkType WorkType;
        public Master Master;
    }
}
