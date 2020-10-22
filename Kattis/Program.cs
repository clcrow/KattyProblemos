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
            private List<double> walkTimes = new List<double>();
            private List<double> driveTimes = new List<double>();
            private List<double> checks = new List<double>();
            private double start, end, timer, arrivalTime;
            private bool checker;
            public void workCode()
            {
                GetInputs1();
                GetInputs2();
                GetInputs3();
                GetInputs4();
                Console.WriteLine(findAnswer(Calculate()));
            }

            private string findAnswer(double final)
            {
                if (final < end) return "yes";
                else return "no";
            }
            private double Calculate()
            {
                for(int i = 0; i < walkTimes.Count; i++)
                {
                    start += walkTimes[i];
                    if (i < driveTimes.Count)
                    {
                        while (!checkFunc())
                        {
                            start += 1;
                        }
                        start += driveTimes[i];
                    }
                }
                return start;
            }


            private bool checkFunc()
            {
                checker = false;
                foreach (double check in checks)
                {
                    if (start % check == 0)
                    {
                        return true;
                    }
                    else checker = false;
                }
                return checker;
            }

            private void GetInputs1()
            {
                string[] inputs1 = Console.ReadLine().Split(' ');
                double.TryParse(inputs1[0], out start);
                double.TryParse(inputs1[1], out end);
            }
            private void GetInputs2()
            {
                string[] inputs2 = Console.ReadLine().Split(' ');
                foreach (string input in inputs2)
                {
                    walkTimes.Add(double.Parse(input));
                }
            }
            private void GetInputs3()
            {
                string[] inputs3 = Console.ReadLine().Split(' ');
                foreach (string input in inputs3)
                {
                    driveTimes.Add(double.Parse(input));
                }
            }
            private void GetInputs4()
            {
                string[] inputs4 = Console.ReadLine().Split(' ');
                foreach (string input in inputs4)
                {
                    checks.Add(double.Parse(input));
                }
            }
        }
    }
}
