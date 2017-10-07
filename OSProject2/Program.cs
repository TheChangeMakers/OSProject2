using System;
using System.Collections;
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

    class FCFS
    {
        public JobList JobList;

        public FCFS(JobList jobList)
        {
            JobList = jobList;
        }

        public void PerformFCFS()
        {
            Job currentJob = null;

            for (int currentTime = 0; currentTime <= JobList.GetTotalJobListProcessTime(); currentTime++)
            {
                // iterate through Joblist
                    // if (!job.AddedToQ && Job.ArrivalTime == currentTime)
                        // job.AddedToQ = true
                        // q.add(job)

                // if ((currentJob == null && !Queue.IsEmpty()) || (currentJob.CyclesRemaining == 0 && !Queue.IsEmpty()))
                    // currentJob = Queue.Pop()

                // decrement currentJob.CycleRemaining
            }
        }

    }

    class Job
    {
        public Job(string jobString)
        {
            // Converts jobString into separate integers and assigns them to ArrivalTime and ReqTimeCycle
            string[] jobValues = jobString.Split(',');
            ArrivalTime = Int32.Parse(jobValues[0]);
            ReqTimeCycles = Int32.Parse(jobValues[1]);
        }
        public int ArrivalTime { get; set; }
        public int ReqTimeCycles { get; set; }
        public int CompletionTime { get; set; }
        public bool IsComplete { get; set; }
        public int JobDuration { get; set; }
        public int CyclesRemaining { get; set; }
    }

    class JobList
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
    
    class Queue
    {
        // bool IsEmpty()
        // void AddToRear()
        // Job PopFromTop()
    }
}