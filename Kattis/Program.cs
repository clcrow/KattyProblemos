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
            private double numSum;
            private string startNum, num;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                num = startNum;
                for(int j = int.Parse(startNum); true; j++)
                {
                    numSum = 0;
                    for (int i = 0; i < num.Length; i++)
                    {
                        numSum += double.Parse(num.Substring(i, 1));
                    }
                    if (j % numSum == 0)
                    {
                        return j;
                    }
                    num = (int.Parse(num) + 1).ToString();
                }
            }

            private void GetInputs()
            {
                startNum = Console.ReadLine();
            }
        }
    }
}
