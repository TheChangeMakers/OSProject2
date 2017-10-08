using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    public class Job
    {
        public Job()
        {
            AddedToQueue = false;
        }

        /*
         * Accepts a string, parses it into separate integers, and assigns the integers to ArrivalTime and ReqTimeCycle
         */
        public Job(string jobString)
        {
            string[] jobValues = jobString.Split(',');
            ArrivalTime = Int32.Parse(jobValues[0]);
            ReqTimeCycles = Int32.Parse(jobValues[1]);
            CyclesRemaining = ReqTimeCycles;
        }

        public int ArrivalTime { get; set; }
        public int ReqTimeCycles { get; set; }
        public int CompletionTime { get; set; }
        //public bool IsComplete { get; set; }
        //public int JobDuration { get; set; }
        public int CyclesRemaining { get; set; }
        public bool AddedToQueue { get; set; }
    }
}
