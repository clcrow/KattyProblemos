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
            string input;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                if (input.Substring(0, 3) == "555") return 1;
                else return 0;
            }

            private void GetInputs()
            {
                input = Console.ReadLine();
            }
        }
    }
}
