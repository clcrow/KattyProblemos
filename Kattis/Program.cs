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
            private string[] inputs;
            private string[] itemWeights;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                int GCVWR = int.Parse(inputs[0]);
                int trWeight = int.Parse(inputs[1]);
                int itemCount = int.Parse(inputs[2]);

                double remainWeight = (GCVWR - trWeight) * .9;
                for(int i=0;i<itemCount;i++)
                {
                    remainWeight -= int.Parse(itemWeights[i]);
                }
                return remainWeight;
            }

            private void GetInputs()
            {
                inputs = Console.ReadLine().Split(' ');
                itemWeights = Console.ReadLine().Split(' ');
            }
        }
    }
}
