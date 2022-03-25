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
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                int index = input.IndexOf("()");
                string firstPart = input.Substring(0, index);
                string secondPart = input.Substring(index + 2);
                if(firstPart == secondPart)
                {
                    return "correct";
                }

                else return "fix";
            }

            private void GetInputs()
            {
                input = Console.ReadLine();
            }
        }
    }
}
