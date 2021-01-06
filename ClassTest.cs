using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SystemTester
{
    class ClassTest
    {
        Itask task;
        string path;

        public ClassTest(Itask itask, string path)
        {
            this.task = itask;
            this.path = path;
        }

        public bool RunTest(string inFile, string outFile)
        {
            string [] data = File.ReadAllLines(inFile);
            string expect = File.ReadAllText(outFile).Trim();
            string actual = task.Run(data);
           
            return actual == expect;
        }
        public void RunTest()
        {
            int nr = 0;
            while (true)
            {
                string inFile = $"{path}\\test.{nr}.in";
                string outFile = $"{path}\\test.{nr}.out";
                if (!File.Exists(inFile) || !File.Exists(outFile))
                    break;

                Console.Write($"Test #{nr} - " + RunTest(inFile, outFile) + "\n");
                nr++;
                

            }
        }
    }
}
