using System.Runtime.CompilerServices;

namespace deliverable1_hello_world_VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution (1): Hello, World!");
            Console.WriteLine(" ");

            string stg = "Hello, World!";
            Console.WriteLine("Solution (2): " + stg);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a username: ");
                string userName = Console.ReadLine();
            Console.WriteLine("The user's name is: "+ userName);

            Console.WriteLine("Enter the user's age: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("The user's age is: " + userAge);
        }
    }
}