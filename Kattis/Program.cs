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
            string[] input;
            string result = "";
            List<int> inputs = new List<int>();
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                inputs.Sort();
                foreach(int i in inputs)
                {
                    result += i.ToString() + ' ';
                }
                return result.Trim();
            }

            private void GetInputs()
            {
                input = Console.ReadLine().Split(' ');
                foreach(string i in input)
                {
                    inputs.Add(int.Parse(i));
                }
            }
        }
    }
}
