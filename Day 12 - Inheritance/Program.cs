using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;
    public Student() { }
    public Student(string firstName, string lastName, int idenidentification, int[] testScores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = idenidentification;
        this.testScores = testScores;
    }

    public String Calculate()
    {
        int temp = 0;
        string totalGrade = "F";
        foreach(int grade in this.testScores)
        {
            temp += grade;
        }

        temp = temp / this.testScores.Length;

        if(temp >= 90)
        {
            totalGrade = "O";
        }else if (temp >= 80)
        {
            totalGrade = "E";
        }
        else if (temp >= 70)
        {
            totalGrade = "A";
        }
        else if (temp >= 55)
        {
            totalGrade = "P";
        }
        else if (temp >= 40)
        {
            totalGrade = "D";
        }
        else
        {
            totalGrade = "T";
        }
        return totalGrade;
    }

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
}

class Solution
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}