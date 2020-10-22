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
            private List<string> inputList = new List<string>();
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                int count;
                foreach(string word in inputList)
                {
                    count = 0;
                    foreach(string word2 in inputList)
                    {
                        if (word == word2) count++;
                    }

                    if (count > 1) return "no";
                }
                return "yes";
            }

            private void GetInputs()
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split(' ');
                foreach (string word in inputArr)
                {
                    inputList.Add(word);
                }
            }
        }
    }
}
