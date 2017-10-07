using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    public class SRT
    {
        public JobList JobList;
        List<Job> JobQueue;

        public SRT(JobList jobList)
        {
            JobList = jobList;
        }

        public void PerformSRT()
        {
            // Stores completed jobs
            List<Job> completedJobs = new List<Job>();

            // Stores incomplete jobs ready for processing
            JobQueue = new List<Job>();

            Job currentJob = null;

            // Start at time 0 and go through total job process time
            for (int currentTime = 0; currentTime <= JobList.GetTotalJobListProcessTime(); currentTime++)
            {
                // add new jobs to Q
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
                    int shortestIndex = FindShortestJob();

                    // assign shortest job in Q to current job
                    currentJob = JobQueue[shortestIndex];

                    // remove job from Q
                    JobQueue.RemoveAt(shortestIndex);
                }

                // test if current job has completed all cycles 
                if (currentJob.CyclesRemaining == 0)
                {
                    // set current job completion time 
                    currentJob.CompletionTime = currentTime;

                    // add job to completed job list
                    completedJobs.Add(currentJob);

                    // test if jobs remaining in Q
                    if (JobQueue[0] != null)
                    {
                        int shortestIndex = FindShortestJob();

                        // assign shortest job in Q to current job
                        currentJob = JobQueue[shortestIndex];

                        // remove job from Q
                        JobQueue.RemoveAt(shortestIndex);
                    }
                }
                else // current job has cycles remaining 
                {
                    // if current job is not shorter than all jobs in Q
                    if (!IsShortest(currentJob))
                    {
                        // find index of new shortest job in Q
                        int indexOfNewShortestJob = FindShortestJob();

                        // add current job to rear of Q
                        JobQueue.Add(currentJob);

                        // assign new shortest job to currentJob
                        currentJob = JobQueue[indexOfNewShortestJob];

                        // remove shortest job from Q
                        JobQueue.RemoveAt(indexOfNewShortestJob);
                    }
                }

                // decrement currentJob.CycleRemaining
                currentJob.CyclesRemaining -= 1;
            }

            // compute turnaround times
            Console.WriteLine("Shortest Remaining Time (SRT) Information:");
            JobList.ComputeTurnaroundTimes(completedJobs);
        }


        /*************** Need to complete *************************/
        public bool IsShortest(Job currentJob)
        {
            bool isShortest;
            return false;
        }

        public int FindShortestJob()
        {
            int currentShortestCycleCount = 0;
            int currentShortestIndex = 0;

            for (int i = 0; i < JobQueue.Count; i++)
            {
                if (currentShortestCycleCount == 0)
                {
                    currentShortestCycleCount = JobQueue[i].CyclesRemaining;
                    currentShortestIndex = i;
                }

                if (JobQueue[i].CyclesRemaining < currentShortestCycleCount)
                {
                    currentShortestCycleCount = JobQueue[i].CyclesRemaining;
                    currentShortestIndex = i;
                }
            }
            return currentShortestIndex;
        }
    }
}
