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
            List<char> answers = new List<char>();
            double questCount, rightAns;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                rightAns = 0;
                int count = answers.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (answers[i] == answers[i + 1])
                    {
                        rightAns++;
                    }
                }
                return rightAns;
            }

            private void GetInputs()
            {
                questCount = double.Parse(Console.ReadLine());
                for (int i = 0; i < questCount; i++)
                {
                    answers.Add(char.Parse(Console.ReadLine()));
                }
            }
        }
    }
}
