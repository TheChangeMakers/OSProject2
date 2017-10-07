using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    public class Program
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

    public class RedRobin
    {
        public JobList JobList;
        public Queue JobQueue;
        public int TimeQuantum { get; set; }

        public RedRobin(JobList jobList)
        {
            JobList = jobList;
        }
    }

    public class Job
    {
        public Job()
        {
            AddedToQueue = false;
        }
        public Job(string jobString)
        {
            // Converts jobString into separate integers and assigns them to ArrivalTime and ReqTimeCycle
            string[] jobValues = jobString.Split(',');
            ArrivalTime = Int32.Parse(jobValues[0]);
            ReqTimeCycles = Int32.Parse(jobValues[1]);
            CyclesRemaining = ReqTimeCycles;
        }
        public int ArrivalTime { get; set; }
        public int ReqTimeCycles { get; set; }
        public int CompletionTime { get; set; }
        public bool IsComplete { get; set; }
        public int JobDuration { get; set; }
        public int CyclesRemaining { get; set; }
        public bool AddedToQueue { get; set; }
    }

    public class JobList
    {
        public List<Job> ListOfJobs;

        // Add a job to the JobList
        public void AddJob(Job job)
        {
            ListOfJobs.Add(job);
        }

        // Get the total process time for all jobs in the JobList
        public int GetTotalJobListProcessTime()
        {
            int processTime = 0;

            foreach (var Job in ListOfJobs)
            {
                processTime += Job.ReqTimeCycles;
            }
            return processTime;
        }

        // Get the total number of jobs in the JobList
        public int GetJobCount()
        {
            int jobCount = 0;
            foreach (var Job in ListOfJobs)
            {
                jobCount++;
            }
            return jobCount;
        }

        /*
         * Accepts list of completed jobs and computes turn around time 
         */ 
        public double ComputeTurnAroundTime(List<Job> completedList)
        {
            // for each job in list, subtract completion time from arrival time, then sum the results
            // divive the sum by GetJobCount()
            // return result
            return 0;
        }
    }

    public class Executable
    {
        public string ExecutableName { get; set; }
    }

    public class File
    {
        public string FileName { get; set; }
    }

    public class TimeQuantum
    {
        public int TQValue { get; set; }
    }
}