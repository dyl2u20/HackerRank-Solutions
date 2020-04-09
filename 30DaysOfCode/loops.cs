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
    static void Main(string[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Enumerable.Range(1, 10).ToList().ForEach(p => Console.WriteLine($"{n} x {p} = {n * p}"));
    }
}
