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
            private int count, tally, decision;
            private string buttonColour;
            public void workCode()
            {
                GetInputs();
                decision = Calculate();
                if (decision == 0)
                {
                    Console.WriteLine("I must watch Star Wars with my daughter");
                }
                else Console.WriteLine(decision);
            }
            private int Calculate()
            {
                tally = 0;
                for(int i = 0; i < count; i++)
                {
                    buttonColour = Console.ReadLine().ToLower();
                    if(buttonColour.Contains("pink") || buttonColour.Contains("rose"))
                    {
                        tally++;
                    }
                }
                return tally;
            }

            private void GetInputs()
            {
                int.TryParse(Console.ReadLine(), out count);
            }
        }
    }
}
