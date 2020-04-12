using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        Dictionary<String, String> phoneBook = new Dictionary<String, String>();
        int n = Convert.ToInt32(Console.ReadLine());
        string input;

        for (int i = 0; i < n; i++) 
        {
            var getInput = Console.ReadLine().Split(' '); 
            phoneBook.Add(getInput[0], getInput[1]); 
        }
        while ((input = Console.ReadLine()) != null)
        {
            try
            {
                Console.WriteLine($"{input}={PhoneBook[input]}");
            }
            catch
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
