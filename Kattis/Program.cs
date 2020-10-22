using System;
using System.Collections.Generic;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string answer = "";
            string result;
            double num1, num2, num3, total;
            string[] inputs;
            Dictionary<int, string> dict = new Dictionary<int, string>();

            input = Console.ReadLine();
            inputs = input.Split(' ');
            num1 = int.Parse(inputs[0]);
            num2 = int.Parse(inputs[1]);
            num3 = int.Parse(inputs[2]);

            total = (num1 * 3) + (num2 * 2) + (num3);

            if (total >= 8)
            {
                answer += "Province or ";
            }

            else if (8 > total && total >= 5)
            {
                answer += "Duchy or ";
            }

            else if (5 > total && total >= 2)
            {
                answer += "Estate or ";
            }

            if (total >= 6)
            {
                answer += "Gold";
            }

            else if (6 > total && total >= 3)
            {
                answer += "Silver";
            }

            else 
            {
                answer += "Copper";
            }

            Console.Clear();
            Console.WriteLine(answer);

        }
    }
}
