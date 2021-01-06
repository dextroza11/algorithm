using System;
using System.Collections.Generic;

namespace SystemTester
{
    class Program
    {
        static void Main(string[] args)
        {

            Itask task = new FenParser();
            ClassTest tester = new ClassTest(task, @"C:\Users\евгений\source\repos\algorithm\bits\0.BITS\3.Bitboard - FEN");
            tester.RunTest();
           




        }
    }
}
