using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            // TESTING: Reading input files from ProjectData folder
            //string inputEasy = System.IO.File.ReadAllText(@"../../ProjectData/Easy.txt");
            //string inputMedium = System.IO.File.ReadAllText(@"../../ProjectData/Medium.txt");
            //string inputHard = System.IO.File.ReadAllText(@"../../ProjectData/Hard.txt");
            //string inputSimple1 = System.IO.File.ReadAllText(@"../../ProjectData/Simple1.txt");
            //string inputSimple2 = System.IO.File.ReadAllText(@"../../ProjectData/Simple2.txt");
            //string inputTextbook = System.IO.File.ReadAllText(@"../../ProjectData/textbook.txt");

            //Console.WriteLine("Easy.txt: \n" + inputEasy);
            //Console.WriteLine();
            //Console.WriteLine("Medium.txt: \n" + inputMedium);
            //Console.WriteLine();
            //Console.WriteLine("Hard.txt: \n" + inputHard);
            //Console.WriteLine();
            //Console.WriteLine("Simple1.txt: \n" + inputSimple1);
            //Console.WriteLine();
            //Console.WriteLine("Simple2.txt: \n" + inputSimple2);
            //Console.WriteLine();
            //Console.WriteLine("textbook.txt: \n" + inputTextbook);
            //Console.WriteLine();
            //Console.ReadLine();
        }
    }

    class Job
    {
        public Job(string jobString)
        {
            // converts jobString into 2 distinct integers, assigning 1st to ArrivalTime and 2nd to ReqTimeCycle
            string[] jobValues = jobString.Split(',');
            ArrivalTime = Int32.Parse(jobValues[0]);
            ReqTimeCycles = Int32.Parse(jobValues[1]);
        }

        public int ArrivalTime { get; set; }
        public int ReqTimeCycles { get; set; }
        public int CompletionTime { get; set; }
        public int JobDuration { get; set; }
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
    class SchedulingAlgorithm
    {
        public Job[] JobsArray; 
        public int PageFaultsCount { get; set; }
        public int TurnAroundTime { get; set; }
        public void FCFS()
        {

        }

        public void SJN()
        {

        }

        public void SRT()
        {

        }

        public void RoundRobin(TimeQuantum timeQuantum)
        {

        }

    }
    class JobList
    {
        public Job[] JobListArray;

        // Method to add job

        public int TotalJobListProcessTime { get; set; }

        // Method to calculate TotalProcessTime (add up req time cycles for all jobs)
    }
}