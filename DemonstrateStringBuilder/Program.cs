using System;
using System.Text;

namespace DemonstrateStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating instance of stringBuilder with size of 100
            StringBuilder sb = new StringBuilder(100);

            sb.Append("Hello ");
            Console.WriteLine(sb);

            sb.Append("World");
            Console.WriteLine(sb);

            sb.AppendLine(", C#");
            Console.WriteLine(sb);

            sb.Insert(15, " Language");
            Console.WriteLine(sb);

            sb.Replace("C#","C++");
            Console.WriteLine(sb);
            Console.WriteLine("Capacity : "+ sb.Capacity);
        }
    }
}
