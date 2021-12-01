using System;

namespace personalregister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell us your name and your salary");
            Console.Write("Type your name: ");

            string myName;
            myName = Console.ReadLine();

            Console.Write("Type your salary: ");
            int mySalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your name is: " + myName);
            Console.WriteLine("Your salary is: " + mySalary);

            Console.ReadLine();

        }
    }
}
