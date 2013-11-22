using System;

namespace IeDotNetUg.Data.Init
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Starting to Initialize the Database");

            DataContext db = new DataContext();

            db.Database.Initialize(true);

            Console.WriteLine("Complete...");

            Console.ReadKey();

        }
    }
}
