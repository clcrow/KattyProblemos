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
            string[] firstInputs = new string[2];
            int buildCount, requestCount;
            List<int> answers = new List<int>();
            public void workCode()
            {
                GetInputs();
                string[] buildLocs = new string[buildCount];
                buildLocs = Console.ReadLine().Split(' ');
                for (int i = 0; i < requestCount; i++)
                {
                    Calculate(buildLocs);
                }
                foreach(int i in answers)
                {
                    Console.WriteLine(i);
                }
            }
            private void Calculate(string[] buildLocs)
            {
                string[] request = new string[3];
                request = Console.ReadLine().Split(' ');
                if(request[0] == "1")
                {
                    buildLocs[int.Parse(request[1]) - 1] = request[2];
                }
                else if(request[0] == "2")
                {
                    int distance = int.Parse(buildLocs[int.Parse(request[1]) - 1]) - int.Parse(buildLocs[int.Parse(request[2]) - 1]);
                    answers.Add(Math.Abs(distance));
                }
            }

            private void GetInputs()
            {
                firstInputs = Console.ReadLine().Split(' ');
                buildCount = int.Parse(firstInputs[0]);
                requestCount = int.Parse(firstInputs[1]);
            }
        }
    }
}
