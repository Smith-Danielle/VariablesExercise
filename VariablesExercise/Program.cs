using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kim";
            int age = 22;
            char firstInitial = 'K';
            bool isEmployed = true;
            double averageDistance = 2.3;
            decimal hoursWorked = 10.55m;



            Console.WriteLine($"My name is {name} and I am {age} years old.");
            Console.WriteLine($"Most people just call me {firstInitial} for short.");
            Console.WriteLine($"It is {isEmployed} that I am employed by Verison.");
            Console.WriteLine($"My job is about {averageDistance} miles from my home and I work about {hoursWorked} hours a week."); 

        }
    }
}
