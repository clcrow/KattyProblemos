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
            public string inputs, str1, str2;
            public int value, moveVal;
            public byte[] asciiFirst, asciiSecond;
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                string newOne = "";
                string newTwo = "";
                string result = "";
                int cutSpot = inputs.Length / 2;
                str1 = inputs.Substring(0, cutSpot);
                str2 = inputs.Substring(cutSpot);
                asciiFirst = Encoding.ASCII.GetBytes(str1);
                asciiSecond = Encoding.ASCII.GetBytes(str2);
                foreach (Byte b in asciiFirst)
                {
                    value = Convert.ToInt32(b);
                    moveVal += (value - 65);
                }
                for (int i = 0; i < cutSpot; i++)
                {
                    int newIntValue = Convert.ToInt32(asciiFirst[i]) + moveVal - 65;
                    while (newIntValue - 26 > 0)
                    {
                        newIntValue -= 26;
                    }
                    newOne += Convert.ToChar(newIntValue + 65);
                }
                moveVal = 0;
                foreach (Byte b in asciiSecond)
                {
                    value = Convert.ToInt32(b);
                    moveVal += (value - 65);
                }
                for (int i = 0; i < cutSpot; i++)
                {
                    int newIntValue = Convert.ToInt32(asciiSecond[i]) + moveVal - 65;
                    while (newIntValue - 26 > 0)
                    {
                        newIntValue -= 26;
                    }
                    newTwo += Convert.ToChar(newIntValue + 65);
                }
                asciiFirst = Encoding.ASCII.GetBytes(newOne);
                asciiSecond = Encoding.ASCII.GetBytes(newTwo);
                for (int i = 0; i < cutSpot; i++)
                {
                    moveVal = Convert.ToInt32(asciiSecond[i]) - 65;
                    int newIntValue = Convert.ToInt32(asciiFirst[i]) - 65 + moveVal;
                    while (newIntValue - 26 >= 0)
                    {
                        newIntValue -= 26;
                    }
                    result += Convert.ToChar(newIntValue + 65);
                }
                return result;
            }

            private void GetInputs()
            {
                inputs = Console.ReadLine();
            }
        }
    }
}
