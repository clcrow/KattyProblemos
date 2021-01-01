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
            public string input;
            public List<string> questSet = new List<string>();
            public int tally;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                tally = 0;
                foreach (string item in questSet)
                {
                    if (item.Contains('-'))
                    {
                        string[] arr = item.Split('-');
                        tally += (int.Parse(arr[1]) - int.Parse(arr[0])) + 1;
                    }
                    else tally += 1;
                }
                return tally;
            }

            private void GetInputs()
            {
                input = Console.ReadLine();
                string[] arr = input.Split(';');
                foreach(string item in arr)
                {
                    questSet.Add(item);
                }
            }
        }
    }
}
