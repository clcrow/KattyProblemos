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
            private long lineCount;
            private List<string> schools = new List<string>();
            private List<string> teams = new List<string>();
            private List<string> finalSchools = new List<string>();
            private List<string> finalTeams = new List<string>();
            public void workCode()
            {
                GetLineNum();
                GetInputs();
                Calculate();
                Output();
            }

            private void Output()
            {
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine(finalSchools[i] + " " + finalTeams[i]);
                }
            }
            private void Calculate()
            {
                int i = 0;
                int j = 0;
                while (i < 12)
                {
                    if(!finalSchools.Contains(schools[j]))
                    {
                        finalSchools.Add(schools[j]);
                        finalTeams.Add(teams[j]);
                        i++;
                    }
                    j++;
                }
            }

            private void GetLineNum()
            {
                long.TryParse(Console.ReadLine(), out lineCount);
            }

            private void GetInputs()
            {
                for (int i = 0; i < lineCount; i++)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    schools.Add(input[0]);
                    teams.Add(input[1]);
                }
            }
        }
    }
}
