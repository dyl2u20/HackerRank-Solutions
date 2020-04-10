using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        string[] holdStrings = new string[t];

        while (i < t) { holdStrings[i++] = Console.ReadLine(); }
        i = 0;

        while (i < t)
        {
            char[] holdChars = holdStrings[i].ToCharArray();
            string even = "", odd = "";
            for (int j = 0; j < holdChars.Length; j++)
            {
                if(j % 2 == 0){even += holdChars[j];}
                else{odd += holdChars[j];} 
            }
            Console.WriteLine($"{even} {odd}");
            i++;
        }
    }   
}
