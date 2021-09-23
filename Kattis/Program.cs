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
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private int Calculate()
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int checker = input.LastIndexOf(input[i]);
                    if (checker != i)
                    {
                        return 0;
                    }
                }
                return 1;
            }

            private void GetInputs()
            {
                input = Console.ReadLine();
            }
        }
    }
}
