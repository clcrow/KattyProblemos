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
            private static string inCases;
            private double cases, days;
            public void workCode()
            {
                GetCaseCount();
                for(int i = 0; i < cases; i++)
                {
                    GetInputs();
                    Console.WriteLine((i + 1).ToString() + ' ' + Calculate().ToString());
                }
            }
            private double Calculate()
            {
                double total = 0;
                for (int i = 1; i <= days; i++)
                {
                    total += i + 1;
                }
                return total;
            }

            private void GetCaseCount()
            {
                inCases = Console.ReadLine();
                cases = double.Parse(inCases);
            }

            private void GetInputs()
            {
                string[] inputs = Console.ReadLine().Split(' ');
                double.TryParse(inputs[1], out days);
            }
        }
    }
}
