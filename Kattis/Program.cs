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
            public int len;
            public List<int> input = new List<int>();
            public List<int> output = new List<int>();
            public List<int> answer = new List<int>();
            public void workCode()
            {
                GetInputs();
                answer = Calculate();
                foreach (int item in answer)
                {
                    Console.WriteLine(item);
                }
            }
            private List<int> Calculate()
            {
                for (int i = 0; i < len; i++)
                {
                    input.Add(int.Parse(Console.ReadLine()));
                }
                for (int j = len-1; j >= 0; j--)
                {
                    output.Add(input[j]);
                }
                return output;
            }

            private void GetInputs()
            {
                len = int.Parse(Console.ReadLine());
            }
        }
    }
}
