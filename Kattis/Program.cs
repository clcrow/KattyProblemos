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
            private double width, count, totalArea;
            private string[] pieceArr;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                totalArea = 0;
                for (int i = 0; i < count; i++)
                {
                    pieceArr = Console.ReadLine().Split(' ');
                    totalArea += double.Parse(pieceArr[0]) * double.Parse(pieceArr[1]);
                }
                return totalArea / width;
            }

            private void GetInputs()
            {
                double.TryParse(Console.ReadLine(), out width);
                double.TryParse(Console.ReadLine(), out count);
            }
        }
    }
}
