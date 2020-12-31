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
            string hey;
            double heycount;
            int yloc;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                hey = hey.Substring(1);
                yloc = hey.IndexOf('y');
                hey = hey.Substring(0, yloc);
                heycount = (hey.Length) * 2;
                hey = "h";
                for (int i = 0; i < heycount; i++)
                {
                    hey += 'e';
                }
                hey += 'y';
                return hey;
            }

            private void GetInputs()
            {
                hey = Console.ReadLine();
            }
        }
    }
}
