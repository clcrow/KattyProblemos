using System;
using System.Collections.Generic;

namespace Kattis
{
    class Program
    {
        static void Main()
        {
            Worker workMan = new Worker();
            workMan.workCode();
        }

        class Worker
        {
            private double cases;
            private List<double> outlets = new List<double>();
            public void workCode()
            {
                GetInputs();
                for (int i = 0; i < cases; i++)
                {
                    Console.WriteLine(Calculate());
                }
            }
            private double Calculate()
            {
                outl
                return 0;
            }

            private void GetInputs()
            {
                cases = double.Parse(Console.ReadLine());
            }
        }
    }
}
