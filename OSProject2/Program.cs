using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            // p2 is the name of the executable
            string p2;

            // fn is the name of the file that contains a sequence of jobs to use for the simulation
            string fn;

            // tq is the Time Quantum value to use for the Round Robin algorithm
            int tq;


        }
    }

    class Job
    {
        public int ArrivalTime { get; set; }
        public int ReqTimeCycles { get; set; }
    }
    class Executable
    {
        public string ExecutableName { get; set; }
    }
    class File
    {
        public string FileName { get; set; }
    }
    class TimeQuantum
    {
        public int TQValue { get; set; }
    }

}
