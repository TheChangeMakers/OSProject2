using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    public class Results
    {
        public string Name { get; set; }

        // to store turnaround time
        public double TT { get; set; }

        public Results(string name, double tT)
        {
            Name = name;
            TT = tT;
        }

    }
}
