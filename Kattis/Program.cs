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
            private int rightSide, leftSide, score;
            private string[] input;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                if ((rightSide == 0) && (leftSide == 0))
                {
                    return "Not a moose";
                }
                else if(rightSide == leftSide)
                {
                    return "Even " + (rightSide + leftSide);
                }
                else
                {
                    if (rightSide > leftSide)
                    {
                        return "Odd " + (rightSide * 2);
                    }
                    else return "Odd " + (leftSide * 2); 
                }
            }

            private void GetInputs()
            {
                input = Console.ReadLine().Split(' ');
                int.TryParse(input[0], out rightSide);
                int.TryParse(input[1], out leftSide);
            }
        }
    }
}
