using System;

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
            private string passOne;
            private string passTwo;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                double count = 0;
                double finalCount;
                if (passOne == passTwo) return 1;
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (passOne[i] != passTwo[i])
                        {
                            count += 1;
                        }
                    }
                    finalCount = Math.Pow(2,count);
                }
                return finalCount;
            }

            private void GetInputs()
            {
                passOne = Console.ReadLine();
                passTwo = Console.ReadLine();
            }
        }
    }
}
