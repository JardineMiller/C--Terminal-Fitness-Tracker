using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            double runningTotal = 0;

            while (true)
            {
                Console.Write("Enter how many minutes you have exercised or type 'quit': ");
                string entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }
                try
                {
                    Separator();
                    double minutes = double.Parse(entry);
                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is an unaccptable value. Try again.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go, hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a Ninja Warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off");
                    }

                    runningTotal += minutes;

                    Console.WriteLine("You've exercised for " + runningTotal + " minutes");
                    Separator();
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid input");
                    continue;
                }            
            }

            Console.WriteLine("Goodbye.");
        }

        static void Separator()
        {
            Console.WriteLine("----------------------");
        }
    }
}