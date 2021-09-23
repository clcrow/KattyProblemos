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
            List<int> inputs = new List<int>();
            int intResult = 0;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                if(count % 2 == 1)
                {
                    return "still running";
                }
                else
                {
                    for(int i = 0; i < count / 2; i++)
                    {
                        intResult += inputs[(i * 2) + 1] - inputs[i * 2];
                    }
                    return intResult.ToString();
                }
            }

            private void GetInputs()
            {
                count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    inputs.Add(int.Parse(Console.ReadLine()));
                }
            }
        }
    }
}
