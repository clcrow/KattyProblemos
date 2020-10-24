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
            private string[] monies;
            private long expenseTotal, expenseCount;
            public void workCode()
            {
                GetInputs();
                if (!allPositive())
                {
                    Console.WriteLine(Calculate());
                }
                else Console.WriteLine('0');
            }

            private bool allPositive()
            {
                for (int i = 0; i < expenseCount; i++)
                {
                    if (0 >= double.Parse(monies[i])) return false;
                }
                return true;
            }
            private long Calculate()
            {
                expenseTotal = 0;
                foreach (string money in monies)
                {
                    if (long.Parse(money) <= 0) expenseTotal += long.Parse(money);
                }
                return 0 - expenseTotal;
            }

            private void GetInputs()
            {
                expenseCount = long.Parse(Console.ReadLine());
                monies = Console.ReadLine().Split(' ');
            }
        }
    }
}
