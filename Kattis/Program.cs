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
            private List<int> outputs = new List<int>();
            public void workCode()
            {
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                string output = "";
                string input;
                for (int i = 1; i < 6; i++)
                {
                    input = Console.ReadLine();
                    if(input.IndexOf("FBI") != -1)
                    {
                        outputs.Add(i);
                    }
                }
                if (outputs.Count > 0)
                {
                    foreach (int i in outputs)
                    {
                        output += i + " ";
                    }
                    output.Trim();
                }
                else output = "HE GOT AWAY!";
                return output;
            }
        }
    }
}
