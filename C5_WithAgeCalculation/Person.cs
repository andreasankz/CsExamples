using System;
using System.Collections.Generic;
using System.Text;

namespace C5_WithAgeCalculation
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }


        public void AskForAge()
        {
            Console.Write("How old are you?");

            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry dude! Your age must be in digits. Try again man.");
                Console.Write("How old are you man? ");
                try
                {
                    Age = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Dude you dumb.");
                }



            }
            finally
            {
                Console.WriteLine($"Oh cool man! We are the same age. I am also {Age}.");
            }

        }


        public void AskForDateOfBirth()
        {

            Console.Write("When were you born? ");
            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.Write("Sorry dude, i mean when, like 1999-01-01- So when are you born?");
                try
                {
                    DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You are so stupid man.");
                }

            }

            Console.WriteLine($"Oh cool man! We are the same age. I am also {CalculateAge()}");


        }

        private int CalculateAge()
        {
            Age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                Age = Age - 1;

            return Age;
        }

    }

   

    







}
