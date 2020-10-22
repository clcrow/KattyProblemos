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
                double.TryParse(inSize, out size);
                double.TryParse(inWideCut, out wideCut);
                double.TryParse(inLenCut, out lenCut);

                if (size - wideCut > size / 2)
                {
                    wideCut = size - wideCut;
                }
                if (size - lenCut > size / 2)
                {
                    lenCut = size - lenCut;
                }
                volume = wideCut * lenCut * 4;

                return volume;
            }

            private void GetInputs()
            {
                string input = Console.ReadLine();
                string[] split = input.Split(' ');
                inSize = split[0];
                inWideCut = split[1];
                inLenCut = split[2];
            }
        }
    }
}
