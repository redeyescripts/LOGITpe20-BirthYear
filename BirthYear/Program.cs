using System;

namespace BirthYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Hello what is your name?");
            String Name;
            Name = Console.ReadLine();
                Console.WriteLine("Hello," + Name);
            Console.WriteLine("What is your age?");

                String UserInput;

            UserInput = Console.ReadLine();
            int Age;
          
            Age = Int32.Parse(UserInput);
            int Year = 2020 - Age;
            Console.WriteLine("You are born in " + Year);
            Console.WriteLine("Hello!," + Name + " Your born year is " + Year);



        }
    }
}
