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
            double[] judgeLine = new double[2];
            List<double> grades = new List<double>();
            public void workCode()
            {
                GetInputs();
                Console.WriteLine(Calculate());
            }
            private string Calculate()
            {
                double[] results = new double[2];
                string strResults = "";
                double leftOver = judgeLine[0] - judgeLine[1];
                double currentScore = 0;
                for(int i = 0; i < judgeLine[1]; i++)
                {
                    currentScore += grades[i];
                }
                results[0] = (currentScore + (leftOver * -3)) / judgeLine[0];
                results[1] = (currentScore + (leftOver * 3)) / judgeLine[0];
                strResults = results[0].ToString() + ' ' + results[1].ToString();
                return strResults;
            }

            private void GetInputs()
            {
                string[] strJudgeLine = Console.ReadLine().Split(' ');
                for (int i = 0; i < 2; i++)
                {
                    judgeLine[i] = double.Parse(strJudgeLine[i]);
                }
                for (int i = 0; i < judgeLine[1]; i++)
                {
                    grades.Add(double.Parse(Console.ReadLine()));
                }
            }
        }
    }
}
