using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution 
{
    static int CalculateFactorial(int n) => n == 0 ? 1 : n * CalculateFactorial(n - 1);

    static void Main(string[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CalculateFactorial((n)));
    }
}
