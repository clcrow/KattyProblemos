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
            private string[] input;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                if(int.Parse(input[0]) > int.Parse(input[1]))
                {
                    return "1";
                }

                else return "0";
            }

            private void GetInputs()
            {
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
