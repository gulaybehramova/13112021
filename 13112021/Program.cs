using System;

namespace _13112021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Generic<string, string> generics = new Generic<string, string>();
            generics.Add("Elnur", "055");
            generics.Add("Gulay", "077");
            generics.Add("Fatime", "010");

            Console.WriteLine(generics.Getname("055"));  
        }
    }
}
