using System;
using System.Linq;

// CLASS GIVEN IN HACKERRANK
class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

// CLASS TO CODE MYSELF
class Student : Person
{
    // Declaring class attributes
    // Assign in default constructor
    private string firstName;
    private string lastName;
    private int id;
    private int[] scores;

    // Defining our default constructor
    public Student(string newFirstName, string newLastName, int newId,
    int[] newScores)
    {
        this.firstName = newFirstName;
        this.lastName = newLastName;
        this.id = newId;
        this.scores = newScores; 
    }
    
    // Returns character based on average score
    public char Calculate()
    {
        int av = scores.Sum() / scores.Length;

        return ( av > 89 ? 'O' : av > 79 ? 'E' 
        : av > 69 ? 'A' : av > 54 ? 'P' 
        : av > 39 ? 'D' : 'T' );
    }

    // Prints the persons name and ID
    public void printPerson()
    {
        Console.WriteLine($"Name: {lastName}, {firstName}\nID: {id}");
    }
}

// CLASS GIVEN IN HACKERRANK
class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}
