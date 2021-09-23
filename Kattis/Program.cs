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
            int count;
            List<string> inputs = new List<string>();
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private int Calculate()
            {
                int result = 0;
                for (int i = 0; i < count-1; i++)
                {
                    int timeOne = int.Parse(inputs[i].Split(' ')[0]);
                    int speedOne = int.Parse(inputs[i].Split(' ')[1]);
                    int timeTwo = int.Parse(inputs[i + 1].Split(' ')[0]);
                    int speedTwo = int.Parse(inputs[i + 1].Split(' ')[1]);

                    int newResult = (speedTwo - speedOne) / (timeTwo - timeOne);
                    if(newResult > result)
                    {
                        result = newResult;
                    }
                }
                return result;
            }

            private void GetInputs()
            {
                count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    inputs.Add(Console.ReadLine());
                }
            }
        }
    }
}
