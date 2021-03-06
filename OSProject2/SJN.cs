﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    public class SJN
    {
        public JobList JobList;
        List<Job> JobQueue;

        public SJN(JobList jobList)
        {
            JobList = jobList;
        }

        /*
         * returns turnaround time 
         */
        public Results PerformSJN()
        {
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
                }

                // test if current job has completed all cycles 
                if (currentJob.CyclesRemaining == 0)
                {
                    // set current job completion time 
                    currentJob.CompletionTime = currentTime;

                    // add job to completed job list
                    completedJobs.Add(currentJob);

                    // test if jobs remaining in Q
                    if (JobQueue.Count != 0)
                    {
                        int shortestIndex = FindShortestJob();

                        // assign shortest job in Q to current job
                        currentJob = JobQueue[shortestIndex];
                        // remove job from Q
                        JobQueue.RemoveAt(shortestIndex);
                    }
                }

                if (currentJob.CyclesRemaining > 0)
                {
                    // decrement currentJob.CycleRemaining
                    currentJob.CyclesRemaining -= 1;
                }
            }

            // compute turnaround times
            Console.WriteLine("Shortest Job Next (SJN) Information:");
            Results newResult = JobList.ComputeTurnaroundTimes("SJN", completedJobs);
            return newResult;
        }

        /*
         * finds index of shortest job in Q
         * the earlier shortest job takes priority
         */
        public int FindShortestJob()
        {
            Job shortestJob = new Job();
            int currentShortestCycleCount = 0;
            int currentShortestIndex = 0;

            for (int i = 0; i < JobQueue.Count; i++)
            {
                if (currentShortestCycleCount == 0)
                {
                    currentShortestCycleCount = JobQueue[i].ReqTimeCycles;
                    currentShortestIndex = i;
                }

                if (JobQueue[i].ReqTimeCycles < currentShortestCycleCount)
                {
                    currentShortestCycleCount = JobQueue[i].ReqTimeCycles;
                    currentShortestIndex = i;
                }
            }
            return currentShortestIndex;
        }
    }
}
