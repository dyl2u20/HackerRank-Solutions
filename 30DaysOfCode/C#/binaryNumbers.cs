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

class Solution {
    static void Main(string[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int consecutive = Convert.ToString(n, 2).Split('0').Select(b => b.Length).Max();
        Console.WriteLine(consecutive);
    }
}
