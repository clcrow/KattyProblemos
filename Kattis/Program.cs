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
            private string[] junkArr;
            private int day, num, smallest;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private int Calculate()
            {
                smallest= 100000000;
                for (int i = 0; i < num; i++)
                {
                    if (int.Parse(junkArr[i]) < smallest)
                    {
                        smallest = int.Parse(junkArr[i]);
                        day = i;
                    }
                }
                return day;
            }

            private void GetInputs()
            {
                int.TryParse(Console.ReadLine(), out num);
                junkArr = Console.ReadLine().Split(' ');
            }
        }
    }
}
