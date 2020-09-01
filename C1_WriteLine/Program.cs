using System;

namespace C1_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\users\andreassaarenpaa\Documents\Documents.txt";
            var path2 = "c:\\users\\andreassaarenpaa\\Documents\\Documents.txt";
            var json = "{\"firstname\" : \"Andreas\", \"lastname\" : \"Olsson\"}";

            string name = "Andreas";
            int age = 30;
            var city = "Lindesberg";


            

            var text1 = "Welcome Andreas! Your are 30 years old right? Andreas do you live in Lindesberg?";
            var text2 = "Welcome " + name + "! You are " + age + " years old right? "; // osv
            var text3 = String.Format("Welcome {0}! Your are {1} years old right? {0} do you live in {2}?", name, age, city);
            var text4 = $"Welcome {name}! Your are {age} years old right? {name} do you live in {city}?";

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);


            
            






        }
    }
}
