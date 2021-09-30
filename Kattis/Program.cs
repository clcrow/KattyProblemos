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
            string[] inputs = new string[4];
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private int Calculate()
            {
                int lapW = int.Parse(inputs[0]);
                int lapH = int.Parse(inputs[1]);
                int stickW = int.Parse(inputs[2]);
                int stickH = int.Parse(inputs[3]);
                if(stickW + 2 <= lapW && stickH + 2 <= lapH)
                {
                    return 1;
                }
                else return 0;
            }

            private void GetInputs()
            {
                inputs = Console.ReadLine().Split(' ');
            }
        }
    }
}
