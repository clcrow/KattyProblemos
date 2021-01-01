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
            private double cases, tally;
            private int outNum;
            private List<int> outlets = new List<int>();
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
                tally = 0;
                string[] arr = Console.ReadLine().Split(' ');
                foreach (string item in arr)
                {
                    outlets.Add(int.Parse(item));
                }
                outNum = outlets[0];
                for(int i = 0; i < outNum - 1; i++)
                {
                    tally += outlets[i + 1] - 1;
                }
                tally += outlets[outNum];
                outlets.Clear();
                return tally;
            }

            private void GetInputs()
            {
                cases = double.Parse(Console.ReadLine());
            }
        }
    }
}
