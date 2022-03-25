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
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                int index = input.IndexOf('a');
                return input.Substring(index);
            }

            private void GetInputs()
            {
                input = Console.ReadLine();
            }
        }
    }
}
