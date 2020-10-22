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
            private static string inSize, inWideCut, inLenCut;
            private double size, wideCut, lenCut, volume;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                return 0;
            }

            private void GetInputs()
            {
            }
        }
    }
}
