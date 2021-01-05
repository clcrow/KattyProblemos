using System;
using System.Collections.Generic;
using System.Text;

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
            public string inputs;
            public int value;
            public byte[] ascii;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private double Calculate()
            {
                foreach (Byte b in ascii)
                {
                    value = Convert.ToInt32(b);
                    Console.WriteLine(value - 64);
                }
                var text = System.Text.Encoding.ASCII.GetString(ascii);
                Console.WriteLine(text);
                return 0;
            }

            private void GetInputs()
            {
                inputs = Console.ReadLine();
                ascii = Encoding.ASCII.GetBytes(inputs);
            }
        }
    }
}
