/*
 * Objective 
In this challenge, we're going to learn about the difference between a class and an instance; because this is an Object Oriented concept, it's only enabled in certain languages. Check out the Tutorial tab for learning materials and an instructional video!

Task 
Write a Person class with an instance variable, , and a constructor that takes an integer, , as a parameter. The constructor must assign  to  after confirming the argument passed as  is not negative; if a negative argument is passed as , the constructor should set  to  and print Age is not valid, setting age to 0.. In addition, you must write the following instance methods:

yearPasses() should increase the  instance variable by .
amIOld() should perform the following conditional actions:
If <13, print You are young..
If  >=13 and <18, print You are a teenager..
Otherwise, print You are old..
*/
using System;
using System.Collections.Generic;
using System.IO;

class Person
{
    public int age;
    public Person(int initialAge)
    {
        // Add some more code to run some checks on initialAge
        if(initialAge < 0)
        {
            Console.WriteLine("Age is not valid, setting age to 0.");
            this.age = 0;
        }
        else
        {
            this.age = initialAge;
        }
    }
    public void amIOld()
    {
        // Do some computations in here and print out the correct statement to the console
        if(this.age < 13)
        {
            Console.WriteLine("You are young.");
        }
        else if(this.age >= 18)
        {
            Console.WriteLine("You are old.");
        }
        else
        {
            Console.WriteLine("You are a teenager.");
        }
    }

    public void yearPasses()
    {
        // Increment the age of the person in here
        this.age++;
    }

    static void Main(String[] args)
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int age = int.Parse(Console.In.ReadLine());
            Person p = new Person(age);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }
    }
}
