using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_рпм_бд_.Models
{
    public class Diagnostic
    {
        public int DiagnosticId;
        public int RequestId;
        public int MasterId;
        public DateTime Date;
        public string Conclusion;

        public Request Request;
        public Master Master;
    }
}
