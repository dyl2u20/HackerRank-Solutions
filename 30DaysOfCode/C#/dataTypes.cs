using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        // Predefined variables from HackerRank
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
    
        // Declare second integer, double, and String variables.
        int j;
        double e;
        string t;
        
        // Read and save an integer, double, and String to your variables.
        j = Convert.ToInt32(Console.ReadLine());
        e = Convert.ToDouble(Console.ReadLine());
        t = Console.ReadLine();

        // Print the sum of both variables on new lines
        Console.WriteLine($"{i + j}\n{(d+e).ToString("F1")}\n{s+t}");
    }
}
