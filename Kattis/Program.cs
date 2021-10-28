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
            int count;
            List<string> inputs = new List<string>();
            public void workCode()
            {
                GetInputs();
                for (int j = 0; j < count; j++)
                {
                    if (j % 2 == 0) Console.WriteLine(inputs[j]);
                }
            }
            private void GetInputs()
            {
                count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    inputs.Add(Console.ReadLine());
                }
            }
        }
    }
}
