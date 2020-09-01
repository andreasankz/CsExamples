﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C4_WithMethods
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }



        public void AskForName()
        {
            Console.Write("Welcome Dude! What's your name? ");
            Name = Console.ReadLine();

            Console.Write($"{Name}, sweet :) ");

        }

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



    }
}
