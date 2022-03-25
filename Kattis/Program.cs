using System;
using System.Collections.Generic;
using System.Linq;

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
            private string input;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private int Calculate()
            {
                int count = 0;
                input = input.ToLower();
                count += input.Count(c => c == 'a');
                count += input.Count(c => c == 'e');
                count += input.Count(c => c == 'i');
                count += input.Count(c => c == 'o');
                count += input.Count(c => c == 'u');
                return count;
            }

            private void GetInputs()
            {
                input = Console.ReadLine();
            }
        }
    }
}
