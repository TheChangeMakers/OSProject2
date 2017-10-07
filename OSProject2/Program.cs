using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
            File easyFile = new File(@"../../ProjectData/Easy.txt");
            JobList easyJobList = easyFile.ReadFile();
            FCFS fcfs = new FCFS(easyJobList);
            fcfs.PerformFCFS();

            // get job count of easyJobList and print to console
            Console.Write(easyJobList.GetJobCount());

            Console.ReadLine();
        }
    }

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
        public bool IsComplete { get; set; }
        public int JobDuration { get; set; }
        public int CyclesRemaining { get; set; }
        public bool AddedToQueue { get; set; }
    }

    public class JobList
    {
        public List<Job> ListOfJobs;

        public JobList()
        {
            ListOfJobs = new List<Job>();
        }

        /*
         * Adds a job to the list
         */
        public void AddJob(Job job)
        {
            ListOfJobs.Add(job);
        }

        /*
         * Returns the total process time for all jobs in the list
         */
        public int GetTotalJobListProcessTime()
        {
            int processTime = 0;

            foreach (var Job in ListOfJobs)
            {
                processTime += Job.ReqTimeCycles;
            }
            return processTime;
        }

        /*
         * Returns the total number of jobs in the list
         */
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
         * Accepts a list of completed jobs and computes the turnaround times for each job and the average turnaround time
         */ 
        public void ComputeTurnaroundTimes(List<Job> completedList)
        {
            double turnaroundTimeSum = 0;

            // for each job in list, subtract arrival time from completion time, and then sum the results
            foreach (var Job in completedList)
            {
                double turnaroundTime = Job.CompletionTime - Job.ArrivalTime;
                Console.WriteLine("\t" + Job + " Turnaround Time: " + turnaroundTime);
                turnaroundTimeSum += turnaroundTime;
            }
            
            // divide the sum of all turnaround times by the total number of jobs to get the average turnaround time
            double averageTurnaroundTime = turnaroundTimeSum / GetJobCount();

            Console.WriteLine("\tAverage Turnaround Time: " + averageTurnaroundTime);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    
    public class Executable
    {
        public string ExecutableName { get; set; }
    }

    public class File
    {
        private StreamReader sr;
        private JobList jobList;

        public File(string path)
        {
            sr = new StreamReader(path);
            jobList = new JobList();
        }

        public JobList ReadFile()
        {
            // read first line of file
            string line = sr.ReadLine();

            // while there are more lines to read
            while (line != null)
            {
                // create a job from line
                Job newJob = new Job(line);

                // add job to list
                jobList.AddJob(newJob);

                // read next line
                line = sr.ReadLine();
            }
            sr.Close();

            return jobList;
        }


        //public string FileName { get; set; }
    }

    public class TimeQuantum
    {
        public int TQValue { get; set; }
    }
}