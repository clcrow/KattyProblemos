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
            string[] inputs = new string[2];
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                return int.Parse(inputs[0]) + int.Parse(inputs[1]);
            }

            private void GetInputs()
            {
                inputs = Console.ReadLine().Split(' ');
            }
        }
    }
}
