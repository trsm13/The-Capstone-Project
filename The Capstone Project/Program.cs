using System;

namespace The_Capstone_Project
{
    class Program
    {
        public static object Pictures { get; private set; }

        private static void Main(string[] args)
        {
            Photography photos = new Photography();

            photos.Name = "Teresia";
            photos.Style = "type";
            photos.Favor = true;
            photos.street = Pictures;

            Console.ForegroundColor = ConsoleColor.Red;
        }

        static void DisplayPhotography(Photography Name)
        {
            Console.WriteLine($"Name: {Photography.Name}");
            Console.WriteLine($"style: {Photography.style}");
            Console.WriteLine($"favor: {Photography.favor}");
            Console.WriteLine($"portraits: {Photography.portraits}");
        }

    }
}
