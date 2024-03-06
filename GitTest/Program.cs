using System;

namespace GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Creating the first two commits!");
            Console.WriteLine("Creating the first new commit using GitHub.com!");

            Console.WriteLine("Creating the 3rd commit!");
            Console.WriteLine("Creating a MySQL commit!");

            Console.WriteLine("Creating the 4th commit!");
            Console.WriteLine("Creating the second new commit using GitHub.com!");

            Console.WriteLine("Creating the 5th commit!");

            string connectionString = "mySQL/myDatabaseName";
           
            MySQL mySQL = new MySQL();
            mySQL.OuterConnect(connectionString);
        }
    }
}
