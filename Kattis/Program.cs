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
            private string input;
            private double count;
            public void workCode()
            {
                GetInputs();
                for (int i = 0; i < count; i++)
                {
                    Calculate();
                }
            }
            private void Calculate()
            {
                input = Console.ReadLine();
                if(input.StartsWith("Simon says"))
                {
                    Console.WriteLine(input.Substring(11));
                }
            }

            private void GetInputs()
            {
                double.TryParse(Console.ReadLine(), out count);
            }
        }
    }
}
