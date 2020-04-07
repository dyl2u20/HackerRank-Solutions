```csharp
using System;
using System.Collections.Generic;
using System.IO;

class Person 
{
    public int age;     
    public Person(int initialAge) 
    {
        if(initialAge < 0){age = 0; Console.WriteLine("Age is not valid, setting age to 0.");} 
        age = initialAge;
     }
     public void amIOld()
     {
         string result = age < 13 ? "You are young." : age < 18  ? "You are a teenager.":"You are old.";
         Console.WriteLine(result);
     }

     public void yearPasses() {age++;}

static void Main(String[] args) {
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            int age=int.Parse(Console.In.ReadLine());
            Person p=new Person(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
}
```
