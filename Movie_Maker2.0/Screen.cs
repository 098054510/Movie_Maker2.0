using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Movie_Maker2._0
{
    class Screen
    {
        public static void ShowScreen()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------Movie Maker-------");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1 - Show All Artists Saved");
            Console.WriteLine("2 - Show datas of Movies"  );
            Console.WriteLine("3 - Register a new Artist" );
            Console.WriteLine("4 - Register a new Movie"  );
            Console.WriteLine("5 - Exit"                  );
            Console.Write    ("Your Choice: "             );
        }

        public static void RegisterMovie()
        {
            Console.Write("Insert how much Movies will be registered: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Insert the data of " + i + " Movie: ");
                Console.Write("Movie Code: ");
                int Code = int.Parse(Console.ReadLine());
                Console.Write("Movie Title: ");
                string Title = Console.ReadLine();
                Console.Write("Main Artist: ");
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Cache: $");
                double Cache = double.Parse(Console.ReadLine());
                Console.Write("Discount: ");
                double PercentDiscount = double.Parse(Console.ReadLine());
                Console.Write("Amount of Something (i can't remeber why i put this option here, so just type 'zero' and press 'ENTER'.");
                int Amount = int.Parse(Console.ReadLine());
                Artist A = new Artist(Code, Name, Cache, PercentDiscount, Amount);
                Movie M = new Movie(Code, Title, A);
                Program.movie.Add(M);
            }

        }
    }
}
