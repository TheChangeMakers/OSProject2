using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    public class FCFS
    {
        public JobList JobList;
        public FCFS(JobList jobList)
        {
            JobList = jobList;
        }

        public void PerformFCFS()
        {
            // Stores completed jobs
            List<Job> completedJobs = new List<Job>();

            // Stores incomplete jobs ready for processing
            List<Job> JobQueue = new List<Job>();

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
                }

                // test if current job has completed all cycles 
                if (currentJob.CyclesRemaining == 0)
                {
                    //set current job completion time 
                    currentJob.CompletionTime = currentTime;

                    // add job to completed job list
                    completedJobs.Add(currentJob);

                    // test if jobs remaining in Q
                    if (JobQueue[0] != null)
                    {
                        // assign first job in Q to current job
                        currentJob = JobQueue[0];
                        // remove job from Q
                        JobQueue.RemoveAt(0);
                    }
                }
                // decrement currentJob.CycleRemaining
                currentJob.CyclesRemaining -= 1;
            }
            // return turn around time
            Console.WriteLine("First-Come, First-Served (FCFS) Information:");
            JobList.ComputeTurnaroundTimes(completedJobs);
        }

    }
}
