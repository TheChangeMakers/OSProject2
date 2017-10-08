using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
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
            Job t;

            // bubble sort list
            for (int p = 0; p <= completedList.Count - 2; p++)
            {
                for (int i = 0; i <= completedList.Count - 2; i++)
                {
                    if (completedList[i].ArrivalTime > completedList[i + 1].ArrivalTime)
                    {
                        t = completedList[i + 1];
                        completedList[i + 1] = completedList[i];
                        completedList[i] = t;
                    }
                }
            }

            double turnaroundTimeSum = 0;

            // for each job in the list, subtract arrival time from completion time and sum the results
            for (int i = 0; i < completedList.Count; i++)
            {
                double turnaroundTime = completedList[i].CompletionTime - completedList[i].ArrivalTime;
                Console.WriteLine("\tJob " + (i + 1) + " Turnaround Time: " + turnaroundTime);
                turnaroundTimeSum += turnaroundTime;
            }

            // divide the sum of all turnaround times by the total number of jobs to get the average turnaround time
            double averageTurnaroundTime = turnaroundTimeSum / GetJobCount();

            Console.WriteLine("\tAverage Turnaround Time: " + averageTurnaroundTime);
            Console.WriteLine();
        }
    }
}
