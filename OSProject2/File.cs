using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    public class File
    {
        private StreamReader sr;
        private JobList jobList;

        public File(string path)
        {
            sr = new StreamReader(path);
            jobList = new JobList();
        }

        /*
         * Reads a file line-by-line and adds jobs to the list
         */
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

            return jobList;
        }
    }
}
