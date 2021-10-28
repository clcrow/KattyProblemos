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
            private string Calculate()
            {
                return input.Substring(1, 1) + input.Substring(0, 1);
            }

            private void GetInputs()
            {
                input = Console.ReadLine();
            }
        }
    }
}
