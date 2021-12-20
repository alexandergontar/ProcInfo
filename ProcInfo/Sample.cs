using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcInfo
{
    public class Sample
    {
        public DateTime dateTime { get; set; }
        public int procId { get; set; }    
        public double cpuUse { get; set; }
        public long workingSet { get; set; }
        public long privateBytes { get; set; }
        public int handleCount { get; set; }
    }
}
