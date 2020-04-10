using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution 
{
    // Complete the solve function below.
     public static double solve(double mealCost, int tipPercent, int taxPercent)
     {
         return _ = Math.Round(mealCost + mealCost * tipPercent / 100 + mealCost * taxPercent / 100);
     }
    static void Main(string[] args)
     {
         // Assign input to declared variables
        double meal_cost = Convert.ToDouble(Console.ReadLine());
        int tip_percent = Convert.ToInt32(Console.ReadLine());
        int tax_percent = Convert.ToInt32(Console.ReadLine());
        
        // Print the meal cost
        Console.WriteLine(solve(meal_cost, tip_percent, tax_percent));
    }
}
