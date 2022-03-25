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
            private string input;
            public void workCode()
            {
                GetInputs();
                Calculate();
            }
            private void Calculate()
            {
                float percent = float.Parse(input);

                float outOne = 100 / percent;

                float outTwo = 100 / (100 - percent);

                Console.WriteLine(outOne);
                Console.WriteLine(outTwo);
            }

            private void GetInputs()
            {
                input = Console.ReadLine();
            }
        }
    }
}
