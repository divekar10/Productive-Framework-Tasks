using System;

namespace DemonstrateUseOfMethodOverloading
{
    class ExMethodOverloading
    {
        //Declared method with 3 parameters
        public void StudentDetails(string fname, string lname, string gender)
        {
            Console.WriteLine("First Name : {0}\nLast Name : {1}\nGender : {2}",fname,lname,gender);
        }

        //declared method with same name but with different parameters
        public void StudentDetails(string fname, string lname, string gender, int age)
        {
            Console.WriteLine("First Name : {0}\nLast Name : {1}\nGender : {2}\nAge : {3}", fname, lname, gender,age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of the class is created
            ExMethodOverloading exMethodOverloading = new ExMethodOverloading();

            //based on the parameters passed, specific method will gets executed
            exMethodOverloading.StudentDetails("John", "Denvor", "Male");
            Console.WriteLine("================================================");
            exMethodOverloading.StudentDetails("Merry", "Jane", "Female", 21);
        }
    }
}
