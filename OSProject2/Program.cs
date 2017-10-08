﻿using System;
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
            // Easy.txt
            Console.WriteLine("Results: Easy.txt");
            Console.WriteLine("-----------------");
            File easyFileFCFS = new File(@"../../ProjectData/Easy.txt");
            JobList easyJobListFCFS = easyFileFCFS.ReadFile();
            FCFS easyFCFS = new FCFS(easyJobListFCFS);
            easyFCFS.PerformFCFS();

            File easyFileSJN = new File(@"../../ProjectData/Easy.txt");
            JobList easyJobListSJN = easyFileSJN.ReadFile();
            SJN easySJN = new SJN(easyJobListSJN);
            easySJN.PerformSJN();

            File easyFileSRT = new File(@"../../ProjectData/Easy.txt");
            JobList easyJobListSRT = easyFileSRT.ReadFile();
            SRT easySRT = new SRT(easyJobListSRT);
            easySRT.PerformSRT();

            File easyFileRR = new File(@"../../ProjectData/Easy.txt");
            JobList easyJobListRR = easyFileRR.ReadFile();
            RoundRobin easyRR = new RoundRobin(easyJobListRR);
            easyRR.PerformRoundRobin(3);

            // Medium.txt
            Console.WriteLine("Results: Medium.txt");
            Console.WriteLine("-------------------");
            File mediumFileFCFS = new File(@"../../ProjectData/Medium.txt");
            JobList mediumJobListFCFS = mediumFileFCFS.ReadFile();
            FCFS mediumFCFS = new FCFS(mediumJobListFCFS);
            mediumFCFS.PerformFCFS();

            File mediumFileSJN = new File(@"../../ProjectData/Medium.txt");
            JobList mediumJobListSJN = mediumFileSJN.ReadFile();
            SJN mediumSJN = new SJN(mediumJobListSJN);
            mediumSJN.PerformSJN();

            File mediumFileSRT = new File(@"../../ProjectData/Medium.txt");
            JobList mediumJobListSRT = mediumFileSRT.ReadFile();
            SRT mediumSRT = new SRT(mediumJobListSRT);
            mediumSRT.PerformSRT();

            File mediumFileRR = new File(@"../../ProjectData/Medium.txt");
            JobList mediumJobListRR = mediumFileRR.ReadFile();
            RoundRobin mediumRR = new RoundRobin(mediumJobListRR);
            mediumRR.PerformRoundRobin(3);

            // Hard.txt
            Console.WriteLine("Results: Hard.txt");
            Console.WriteLine("-----------------");
            File hardFileFCFS = new File(@"../../ProjectData/Hard.txt");
            JobList hardJobListFCFS = hardFileFCFS.ReadFile();
            FCFS hardFCFS = new FCFS(hardJobListFCFS);
            hardFCFS.PerformFCFS();

            File hardFileSJN = new File(@"../../ProjectData/Hard.txt");
            JobList hardJobListSJN = hardFileSJN.ReadFile();
            SJN hardSJN = new SJN(hardJobListSJN);
            hardSJN.PerformSJN();

            File hardFileSRT = new File(@"../../ProjectData/Hard.txt");
            JobList hardJobListSRT = hardFileSRT.ReadFile();
            SRT hardSRT = new SRT(hardJobListSRT);
            hardSRT.PerformSRT();

            File hardFileRR = new File(@"../../ProjectData/Hard.txt");
            JobList hardJobListRR = hardFileRR.ReadFile();
            RoundRobin hardRR = new RoundRobin(hardJobListRR);
            hardRR.PerformRoundRobin(3);

            // Simple1.txt
            Console.WriteLine("Results: Simple1.txt");
            Console.WriteLine("--------------------");
            File simple1FileFCFS = new File(@"../../ProjectData/Simple1.txt");
            JobList simple1JobListFCFS = simple1FileFCFS.ReadFile();
            FCFS simple1FCFS = new FCFS(simple1JobListFCFS);
            simple1FCFS.PerformFCFS();

            File simple1FileSJN = new File(@"../../ProjectData/Simple1.txt");
            JobList simple1JobListSJN = simple1FileSJN.ReadFile();
            SJN simple1SJN = new SJN(simple1JobListSJN);
            simple1SJN.PerformSJN();

            File simple1FileSRT = new File(@"../../ProjectData/Simple1.txt");
            JobList simple1JobListSRT = simple1FileSRT.ReadFile();
            SRT simple1SRT = new SRT(simple1JobListSRT);
            simple1SRT.PerformSRT();

            File simple1FileRR = new File(@"../../ProjectData/Simple1.txt");
            JobList simple1JobListRR = simple1FileRR.ReadFile();
            RoundRobin simple1RR = new RoundRobin(simple1JobListRR);
            simple1RR.PerformRoundRobin(3);

            // Simple2.txt
            Console.WriteLine("Results: Simple2.txt");
            Console.WriteLine("--------------------");
            File simple2FileFCFS = new File(@"../../ProjectData/Simple2.txt");
            JobList simple2JobListFCFS = simple2FileFCFS.ReadFile();
            FCFS simple2FCFS = new FCFS(simple2JobListFCFS);
            simple2FCFS.PerformFCFS();

            File simple2FileSJN = new File(@"../../ProjectData/Simple2.txt");
            JobList simple2JobListSJN = simple2FileSJN.ReadFile();
            SJN simple2SJN = new SJN(simple2JobListSJN);
            simple2SJN.PerformSJN();

            File simple2FileSRT = new File(@"../../ProjectData/Simple2.txt");
            JobList simple2JobListSRT = simple2FileSRT.ReadFile();
            SRT simple2SRT = new SRT(simple2JobListSRT);
            simple2SRT.PerformSRT();

            File simple2FileRR = new File(@"../../ProjectData/Simple2.txt");
            JobList simple2JobListRR = simple2FileRR.ReadFile();
            RoundRobin simple2RR = new RoundRobin(simple2JobListRR);
            simple2RR.PerformRoundRobin(3);

            // textbook.txt
            Console.WriteLine("Results: textbook.txt");
            Console.WriteLine("---------------------");
            File textbookFileFCFS = new File(@"../../ProjectData/textbook.txt");
            JobList textbookJobListFCFS = textbookFileFCFS.ReadFile();
            FCFS textbookFCFS = new FCFS(textbookJobListFCFS);
            textbookFCFS.PerformFCFS();

            File textbookFileSJN = new File(@"../../ProjectData/textbook.txt");
            JobList textbookJobListSJN = textbookFileSJN.ReadFile();
            SJN textbookSJN = new SJN(textbookJobListSJN);
            textbookSJN.PerformSJN();

            File textbookFileSRT = new File(@"../../ProjectData/textbook.txt");
            JobList textbookJobListSRT = textbookFileSRT.ReadFile();
            SRT textbookSRT = new SRT(textbookJobListSRT);
            textbookSRT.PerformSRT();

            File textbookFileRR = new File(@"../../ProjectData/textbook.txt");
            JobList textbookJobListRR = textbookFileRR.ReadFile();
            RoundRobin textbookRR = new RoundRobin(textbookJobListRR);
            textbookRR.PerformRoundRobin(3);

            Console.ReadLine();
        }
    }
}