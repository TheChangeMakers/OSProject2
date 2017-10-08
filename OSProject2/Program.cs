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
            ResultsList easyList = new ResultsList();

            // Easy.txt
            Console.WriteLine("Results: Easy.txt");
            Console.WriteLine("-----------------");
            File easyFileFCFS = new File(@"../../ProjectData/Easy.txt");
            JobList easyJobListFCFS = easyFileFCFS.ReadFile();
            FCFS easyFCFS = new FCFS(easyJobListFCFS);
            Results easyFCFSResult = easyFCFS.PerformFCFS();
            easyList.AddResult(easyFCFSResult);

            File easyFileSJN = new File(@"../../ProjectData/Easy.txt");
            JobList easyJobListSJN = easyFileSJN.ReadFile();
            SJN easySJN = new SJN(easyJobListSJN);
            Results easySJNResult = easySJN.PerformSJN();
            easyList.AddResult(easySJNResult);

            File easyFileSRT = new File(@"../../ProjectData/Easy.txt");
            JobList easyJobListSRT = easyFileSRT.ReadFile();
            SRT easySRT = new SRT(easyJobListSRT);
            Results easySRTResult = easySRT.PerformSRT();
            easyList.AddResult(easySRTResult);

            File easyFileRR = new File(@"../../ProjectData/Easy.txt");
            JobList easyJobListRR = easyFileRR.ReadFile();
            RoundRobin easyRR = new RoundRobin(easyJobListRR);
            Results easyRRResult = easyRR.PerformRoundRobin(3);
            easyList.AddResult(easyRRResult);
            easyList.ComputeBestResult();


            ResultsList mediumList = new ResultsList();

            // Medium.txt
            Console.WriteLine("Results: Medium.txt");
            Console.WriteLine("-------------------");
            File mediumFileFCFS = new File(@"../../ProjectData/Medium.txt");
            JobList mediumJobListFCFS = mediumFileFCFS.ReadFile();
            FCFS mediumFCFS = new FCFS(mediumJobListFCFS);
            Results mediumFCFSResult = mediumFCFS.PerformFCFS();
            mediumList.AddResult(mediumFCFSResult);

            File mediumFileSJN = new File(@"../../ProjectData/Medium.txt");
            JobList mediumJobListSJN = mediumFileSJN.ReadFile();
            SJN mediumSJN = new SJN(mediumJobListSJN);
            Results mediumSJNResult = mediumSJN.PerformSJN();
            mediumList.AddResult(mediumSJNResult);

            File mediumFileSRT = new File(@"../../ProjectData/Medium.txt");
            JobList mediumJobListSRT = mediumFileSRT.ReadFile();
            SRT mediumSRT = new SRT(mediumJobListSRT);
            Results mediumSRTResult = mediumSRT.PerformSRT();
            mediumList.AddResult(mediumSRTResult);

            File mediumFileRR = new File(@"../../ProjectData/Medium.txt");
            JobList mediumJobListRR = mediumFileRR.ReadFile();
            RoundRobin mediumRR = new RoundRobin(mediumJobListRR);
            Results mediumRRResult = mediumRR.PerformRoundRobin(3);
            mediumList.AddResult(mediumRRResult);
            mediumList.ComputeBestResult();


            ResultsList hardList = new ResultsList();
            // Hard.txt
            Console.WriteLine("Results: Hard.txt");
            Console.WriteLine("-----------------");
            File hardFileFCFS = new File(@"../../ProjectData/Hard.txt");
            JobList hardJobListFCFS = hardFileFCFS.ReadFile();
            FCFS hardFCFS = new FCFS(hardJobListFCFS);
            Results hardFCFSResults = hardFCFS.PerformFCFS();
            hardList.AddResult(hardFCFSResults);

            File hardFileSJN = new File(@"../../ProjectData/Hard.txt");
            JobList hardJobListSJN = hardFileSJN.ReadFile();
            SJN hardSJN = new SJN(hardJobListSJN);
            Results hardSJNResults = hardSJN.PerformSJN();
            hardList.AddResult(hardSJNResults);


            File hardFileSRT = new File(@"../../ProjectData/Hard.txt");
            JobList hardJobListSRT = hardFileSRT.ReadFile();
            SRT hardSRT = new SRT(hardJobListSRT);
            Results hardSRTresults = hardSRT.PerformSRT();
            hardList.AddResult(hardSRTresults);

            File hardFileRR = new File(@"../../ProjectData/Hard.txt");
            JobList hardJobListRR = hardFileRR.ReadFile();
            RoundRobin hardRR = new RoundRobin(hardJobListRR);
            Results hardRRResults = hardRR.PerformRoundRobin(3);
            hardList.AddResult(hardRRResults);
            hardList.ComputeBestResult();



            ResultsList simple1List = new ResultsList();
            // Simple1.txt
            Console.WriteLine("Results: Simple1.txt");
            Console.WriteLine("--------------------");
            File simple1FileFCFS = new File(@"../../ProjectData/Simple1.txt");
            JobList simple1JobListFCFS = simple1FileFCFS.ReadFile();
            FCFS simple1FCFS = new FCFS(simple1JobListFCFS);
            Results simple1FCFSResults = simple1FCFS.PerformFCFS();
            simple1List.AddResult(simple1FCFSResults);

            File simple1FileSJN = new File(@"../../ProjectData/Simple1.txt");
            JobList simple1JobListSJN = simple1FileSJN.ReadFile();
            SJN simple1SJN = new SJN(simple1JobListSJN);
            Results simple1SJNResult = simple1SJN.PerformSJN();
            simple1List.AddResult(simple1SJNResult);

            File simple1FileSRT = new File(@"../../ProjectData/Simple1.txt");
            JobList simple1JobListSRT = simple1FileSRT.ReadFile();
            SRT simple1SRT = new SRT(simple1JobListSRT);
            Results simple1SRTResult = simple1SRT.PerformSRT();
            simple1List.AddResult(simple1SRTResult);

            File simple1FileRR = new File(@"../../ProjectData/Simple1.txt");
            JobList simple1JobListRR = simple1FileRR.ReadFile();
            RoundRobin simple1RR = new RoundRobin(simple1JobListRR);
            Results simple1RRREsult = simple1RR.PerformRoundRobin(3);
            simple1List.AddResult(simple1RRREsult);
            simple1List.ComputeBestResult();


            ResultsList simple2List = new ResultsList();
            // Simple2.txt
            Console.WriteLine("Results: Simple2.txt");
            Console.WriteLine("--------------------");
            File simple2FileFCFS = new File(@"../../ProjectData/Simple2.txt");
            JobList simple2JobListFCFS = simple2FileFCFS.ReadFile();
            FCFS simple2FCFS = new FCFS(simple2JobListFCFS);
            Results simple2FCFSResult = simple2FCFS.PerformFCFS();
            simple2List.AddResult(simple2FCFSResult);

            File simple2FileSJN = new File(@"../../ProjectData/Simple2.txt");
            JobList simple2JobListSJN = simple2FileSJN.ReadFile();
            SJN simple2SJN = new SJN(simple2JobListSJN);
            Results simple2SJNResult = simple2SJN.PerformSJN();
            simple2List.AddResult(simple2SJNResult);

            File simple2FileSRT = new File(@"../../ProjectData/Simple2.txt");
            JobList simple2JobListSRT = simple2FileSRT.ReadFile();
            SRT simple2SRT = new SRT(simple2JobListSRT);
            Results simple2SRTResult = simple2SRT.PerformSRT();
            simple2List.AddResult(simple2SRTResult);

            File simple2FileRR = new File(@"../../ProjectData/Simple2.txt");
            JobList simple2JobListRR = simple2FileRR.ReadFile();
            RoundRobin simple2RR = new RoundRobin(simple2JobListRR);
            Results simple2RRResult = simple2RR.PerformRoundRobin(3);
            simple2List.AddResult(simple2RRResult);
            simple2List.ComputeBestResult();


            ResultsList tbList = new ResultsList();
            // textbook.txt
            Console.WriteLine("Results: textbook.txt");
            Console.WriteLine("---------------------");
            File textbookFileFCFS = new File(@"../../ProjectData/textbook.txt");
            JobList textbookJobListFCFS = textbookFileFCFS.ReadFile();
            FCFS textbookFCFS = new FCFS(textbookJobListFCFS);
            Results tbFCFSResult = textbookFCFS.PerformFCFS();
            tbList.AddResult(tbFCFSResult);

            File textbookFileSJN = new File(@"../../ProjectData/textbook.txt");
            JobList textbookJobListSJN = textbookFileSJN.ReadFile();
            SJN textbookSJN = new SJN(textbookJobListSJN);
            Results tbSJNResult = textbookSJN.PerformSJN();
            tbList.AddResult(tbSJNResult);

            File textbookFileSRT = new File(@"../../ProjectData/textbook.txt");
            JobList textbookJobListSRT = textbookFileSRT.ReadFile();
            SRT textbookSRT = new SRT(textbookJobListSRT);
            Results tbSRTResults = textbookSRT.PerformSRT();
            tbList.AddResult(tbSRTResults);


            File textbookFileRR = new File(@"../../ProjectData/textbook.txt");
            JobList textbookJobListRR = textbookFileRR.ReadFile();
            RoundRobin textbookRR = new RoundRobin(textbookJobListRR);
            Results tbRRResults = textbookRR.PerformRoundRobin(3);
            tbList.AddResult(tbRRResults);
            tbList.ComputeBestResult();


            Console.WriteLine("Results: Red Robin Trials with medium.txt");
            Console.WriteLine("------------------------------------------");

            mediumFileRR = new File(@"../../ProjectData/Medium.txt");
            mediumJobListRR = mediumFileRR.ReadFile();
            mediumRR = new RoundRobin(mediumJobListRR);
            mediumRRResult = mediumRR.PerformRoundRobin(1);

            mediumList = new ResultsList();
            mediumFileRR = new File(@"../../ProjectData/Medium.txt");
            mediumJobListRR = mediumFileRR.ReadFile();
            mediumRR = new RoundRobin(mediumJobListRR);
            mediumRRResult = mediumRR.PerformRoundRobin(2);

            mediumList = new ResultsList();
            mediumFileRR = new File(@"../../ProjectData/Medium.txt");
            mediumJobListRR = mediumFileRR.ReadFile();
            mediumRR = new RoundRobin(mediumJobListRR);
            mediumRRResult = mediumRR.PerformRoundRobin(5);

            mediumList = new ResultsList();
            mediumFileRR = new File(@"../../ProjectData/Medium.txt");
            mediumJobListRR = mediumFileRR.ReadFile();
            mediumRR = new RoundRobin(mediumJobListRR);
            mediumRRResult = mediumRR.PerformRoundRobin(10);

            mediumList = new ResultsList();
            mediumFileRR = new File(@"../../ProjectData/Medium.txt");
            mediumJobListRR = mediumFileRR.ReadFile();
            mediumRR = new RoundRobin(mediumJobListRR);
            mediumRRResult = mediumRR.PerformRoundRobin(15);

            mediumList = new ResultsList();
            mediumFileRR = new File(@"../../ProjectData/Medium.txt");
            mediumJobListRR = mediumFileRR.ReadFile();
            mediumRR = new RoundRobin(mediumJobListRR);
            mediumRRResult = mediumRR.PerformRoundRobin(20);

            Console.ReadLine();
        }
    }
}