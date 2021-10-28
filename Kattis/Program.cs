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
            string count;
            string[] inputs;
            double answer = 0;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                foreach(string i in inputs)
                {
                    answer += int.Parse(i);
                }
                return answer;
            }

            private void GetInputs()
            {
                count = Console.ReadLine();
                inputs = new string[int.Parse(count)];
                inputs = Console.ReadLine().Split(' ');
            }
        }
    }
}
