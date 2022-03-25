using System;
using System.Collections.Generic;
using System.Linq;

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
            private string count;
            private List<string> neededKnots;
            private List<string> knownKnots;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                for (int i = 0; i < int.Parse(count) - 1; i++)
                {
                    if(neededKnots.Contains(knownKnots[i]))
                    {
                        neededKnots.Remove(knownKnots[i]);
                    }
                }
                return neededKnots[0];
            }

            private void GetInputs()
            {
                count = Console.ReadLine();
                neededKnots = Console.ReadLine().Split(' ').ToList();
                knownKnots = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
