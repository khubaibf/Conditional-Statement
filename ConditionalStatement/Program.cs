using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine("Enter your expected marks for ISM 4300 ");
                    int points = int.Parse(Console.ReadLine());
                    if (points < 0 || points > 100)
                    {
                        Console.WriteLine("You have entered invalid marks, they should be between 0-100");

                    }
                    else if (points < 60)
                    {
                        Console.WriteLine("Grade F");
                    }
                    else if (points >= 60 && points <= 61)
                    {
                        Console.WriteLine("Grade D-");
                    }
                    else if (points >= 62 && points <= 67)
                    {
                        Console.WriteLine("Grade D");
                    }
                    else if (points >= 68 && points <= 69)
                    {
                        Console.WriteLine("Grade D+");
                    }
                    else if (points >= 70 && points <= 71)
                    {
                        Console.WriteLine("Grade C-");
                    }
                    else if (points >= 72 && points <= 77)
                    {
                        Console.WriteLine("Grade C");
                    }
                    else if (points >= 78 && points <= 79)
                    {
                        Console.WriteLine("Grade C+");
                    }
                    else if (points >= 80 && points <= 81)
                    {
                        Console.WriteLine("Grade B-");
                    }
                    else if (points >= 82 && points <= 87)
                    {
                        Console.WriteLine("Grade B");
                    }
                    else if (points >= 88 && points <= 89)
                    {
                        Console.WriteLine("Grade B+");
                    }
                    else if (points >= 90 && points <= 91)
                    {
                        Console.WriteLine("Grade A-");
                    }
                    else if (points >= 92 && points <= 97)
                    {
                        Console.WriteLine("Grade A");
                    }
                    else if (points >= 98 && points <= 100)
                    {
                        Console.WriteLine("Grade A+");
                    }
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("For the program to work correclty, enter only integer");
            }
        }
    }
}
