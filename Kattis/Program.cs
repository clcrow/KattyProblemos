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
            string[] inputs = new string[3];
            int result;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                result = Int32.Parse(inputs[0]) * Int32.Parse(inputs[1]) * Int32.Parse(inputs[2]);
                return result;
            }

            private void GetInputs()
            {
                inputs = Console.ReadLine().Split(' ');
            }
        }
    }
}
