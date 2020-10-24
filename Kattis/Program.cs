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
            private List<int> moduloList = new List<int>();
            private int modulo;
            public void workCode()
            {
                //GetInputs();
                for(int i = 0; i < 10; i++)
                {
                    Calculate();
                }
                Console.WriteLine(moduloList.Count);
            }
            private void Calculate()
            {
                modulo = (int.Parse(Console.ReadLine()) % 42);
                if (!moduloList.Contains(modulo))
                {
                    moduloList.Add(modulo);
                }
            }

            //private void GetInputs()
            //{
            //}
        }
    }
}
