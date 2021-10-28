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
                double answer = (double.Parse(inputs[0]) * double.Parse(inputs[1])) / 2;
                return answer;
            }

            private void GetInputs()
            {
                inputs = Console.ReadLine().Split(' ');
            }
        }
    }
}
