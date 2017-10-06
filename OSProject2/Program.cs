using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            // TESTING: Reading input files from ProjectData folder
            string inputEasy = System.IO.File.ReadAllText(@"../../ProjectData/Easy.txt");
            string inputMedium = System.IO.File.ReadAllText(@"../../ProjectData/Medium.txt");
            string inputHard = System.IO.File.ReadAllText(@"../../ProjectData/Hard.txt");
            string inputSimple1 = System.IO.File.ReadAllText(@"../../ProjectData/Simple1.txt");
            string inputSimple2 = System.IO.File.ReadAllText(@"../../ProjectData/Simple2.txt");
            string inputTextbook = System.IO.File.ReadAllText(@"../../ProjectData/textbook.txt");

            Console.WriteLine("Easy.txt: \n" + inputEasy);
            Console.WriteLine();
            Console.WriteLine("Medium.txt: \n" + inputMedium);
            Console.WriteLine();
            Console.WriteLine("Hard.txt: \n" + inputHard);
            Console.WriteLine();
            Console.WriteLine("Simple1.txt: \n" + inputSimple1);
            Console.WriteLine();
            Console.WriteLine("Simple2.txt: \n" + inputSimple2);
            Console.WriteLine();
            Console.WriteLine("textbook.txt: \n" + inputTextbook);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}