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
            string result;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                result = input + ' ' + input + ' ' + input;
                return result;
            }

            private void GetInputs()
            {
                input = Console.ReadLine();
            }
        }
    }
}
