using System;

namespace DemonstrateUseOfConstructor
{

    class ExampleConstructor
    {
        //variable declared but not assigned any value
        string fname;
        string lname;
        int age;

        //Creating a constructor
        //Constructor will be automatically when we create instance of class
        public ExampleConstructor()
        {
            //Value will be automatically assigned when instance of a class is create
            fname = "Sachin";
            lname = "Tendulkar";
            age = 48;
        }

        public void DisplayData()
        {
            //Displaying data, assigned in the constructor
            Console.WriteLine("First Name : {0}\nLast Name : {1}\nAge : {2}", fname, lname, age);
        }

    }


    public class Program
    {
        static void Main(string[] args)
        {
            // creating instance of a class
            ExampleConstructor obj = new ExampleConstructor();
            obj.DisplayData();
        }
    }
}
