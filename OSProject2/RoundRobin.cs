using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    public class RoundRobin
    {
        public JobList JobList;
        List<Job> JobQueue;

        public RoundRobin(JobList jobList)
        {
            JobList = jobList;
        }

        public void PerformRoundRobin(int timeQuantum)
        {
            int currentTimeQuantumValue = timeQuantum;

            // Stores completed jobs
            List<Job> completedJobs = new List<Job>();

            // Stores incomplete jobs ready for processing
            JobQueue = new List<Job>();

            Job currentJob = null;

            // Start at time 0 and go through total job process time
            for (int currentTime = 0; currentTime <= JobList.GetTotalJobListProcessTime(); currentTime++)
            {
                // add new jobs to queue
                for (int i = 0; i < JobList.GetJobCount(); i++)
                {
                    // if job is not in Q and job arrival time = current time
                    if (!JobList.ListOfJobs[i].AddedToQueue && JobList.ListOfJobs[i].ArrivalTime == currentTime)
                    {
                        // add job to Q 
                        JobQueue.Add(JobList.ListOfJobs[i]);
                        JobList.ListOfJobs[i].AddedToQueue = true;
                    }
                }

                // only executes once, at beginning 
                if (currentJob == null)
                {
                    // assign 1st job in Q to current job
                    currentJob = JobQueue[0];

                    // remove job from Q
                    JobQueue.RemoveAt(0);

                    // reset time quantum
                    currentTimeQuantumValue = timeQuantum;
                }

                // test if current job has completed all cycles 
                if (currentJob.CyclesRemaining == 0)
                {
                    //set current job completion time 
                    currentJob.CompletionTime = currentTime;

                    // add job to completed job list
                    completedJobs.Add(currentJob);

                    // test if jobs remaining in Q
                    if (JobQueue.Count != 0)
                    {
                        // assign first job in Q to current job
                        currentJob = JobQueue[0];

                        // remove job from Q
                        JobQueue.RemoveAt(0);

                        // reset time quantum
                        currentTimeQuantumValue = timeQuantum;
                    }
                }
                else // current job has cycles remaining 
                {
                    // if time quantum has expired
                    if (currentTimeQuantumValue == 0 && JobQueue.Count != 0)
                    {
                        // add current job to rear of Q
                        JobQueue.Add(currentJob);

                        // assign 1st job in Q to current job
                        currentJob = JobQueue[0];

                        // reset time quantum
                        currentTimeQuantumValue = timeQuantum;
                    }
                }

                if (currentJob.CyclesRemaining > 0)
                {
                    // decrement time quantum
                    currentTimeQuantumValue -= 1;

                    // decrement currentJob.CycleRemaining
                    currentJob.CyclesRemaining -= 1;
                }
            }

            // compute turnaround times
            Console.WriteLine("Round Robin (TQ=" + timeQuantum + ") Information:");
            JobList.ComputeTurnaroundTimes(completedJobs);
        }
    }
}
