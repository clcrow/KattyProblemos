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
            public string answer;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                answer = "";

                char[] inputarr = input.ToCharArray();
                for (int i = 0; i < inputarr.Length; i++)
                {
                    if ((inputarr[i] == 'a' || inputarr[i] == 'e') || (inputarr[i] == 'i' || inputarr[i] == 'o') || inputarr[i] == 'u')
                    {
                        answer += inputarr[i];
                        i += 2;
                    }
                    else answer += inputarr[i];
                }
                return answer;
            }

            private void GetInputs()
            {
                input = Console.ReadLine();
            }
        }
    }
}
