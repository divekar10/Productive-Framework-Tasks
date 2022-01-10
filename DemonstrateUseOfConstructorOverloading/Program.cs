using System;

namespace DemonstrateUseOfConstructorOverloading
{
    class Addition
    {
        //Declaring parameterized constructor
        public Addition(double subject1, double subject2)
        {
            double sum;
            sum = subject1 + subject2;
            Console.WriteLine(sum);
        }

        //Declaring parameterized constructor with different parameters
        public Addition(double subject1, double subject2, double subject3)
        {
            double sum;
            sum = subject1 + subject2 + subject3;
            Console.WriteLine(sum);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of Two subjects :");
            Addition addition = new Addition(56, 60);

            Console.WriteLine("Addition of Three subjects :");
            Addition addition1 = new Addition(60, 55, 65);
        }
    }
}
