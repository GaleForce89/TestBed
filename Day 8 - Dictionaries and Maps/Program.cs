using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {

        Dictionary<string, int> phoneMap = new Dictionary<string, int>();

        string input = Console.ReadLine();
        int n = Convert.ToInt32(input);

        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            string name = values[0];
            int number = Convert.ToInt32(values[1]);

            phoneMap.Add(name, number);
        }

        for (int j = 0; j < n; j++)
        {
            string check = Console.ReadLine();
            if (phoneMap.ContainsKey(check))
            {
                int output = phoneMap[check];
                Console.WriteLine("{0}={1}", check, output);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}