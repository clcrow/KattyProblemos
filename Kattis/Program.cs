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
            int result = 0;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private int Calculate()
            {
                foreach(int i in inputs)
                {
                    result += i;
                }
                return result - (count - 1);
            }

            private void GetInputs()
            {
                count = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    inputs.Add(Int32.Parse(Console.ReadLine()));
                }
            }
        }
    }
}
