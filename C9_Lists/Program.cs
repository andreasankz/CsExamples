using System;
using System.Collections.Generic;

namespace C9_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _hasSiblings;

            Console.Write("Do you have any siblings? (yes/no) ");
            var _siblingRespons = Console.ReadLine();

            switch (_siblingRespons.ToLower())
            {
                case "yes":
                    _hasSiblings = true;
                    break;

                case "no":
                    _hasSiblings = false;
                    break;

                default:
                    _hasSiblings = false;
                    break;
            }

            if (!_hasSiblings)
                Console.WriteLine("Okey, that's cool man.");
            else
            {
                Console.Write("Sweet. How many siblings do you have? ");
                int _numberOfSiblings = Convert.ToInt32(Console.ReadLine());

                var siblings = new List<string>();

                if (_numberOfSiblings == 1)
                {
                    Console.Write("What's your siblings name? ");
                    siblings.Add(Console.ReadLine());

                    Console.WriteLine($"Okey so you siblings name is {siblings[0]}");
                }
                else
                {
                    Console.Write("What's your siblings name? Seperat by comma(,) ");
                    var _response = Console.ReadLine();

                    var names = _response.Replace(" ", "").Split(",");

                    foreach (var name in names)
                    {
                        siblings.Add(name);
                    }

                    Console.Write("Which of your siblings are the oldest one? ");
                    var _oldest = Console.ReadLine();

                    var index = siblings.FindIndex(x => x.Contains(_oldest));

                    siblings.RemoveAt(index);
                    siblings.Insert(0, _oldest);

                    Console.Write($"Okay, So your siblings names are ");
                    foreach(var sibling in siblings)
                    {
                        Console.Write($"{sibling} ");
                    }

                }
                   

                
            }


        }
    }
}
