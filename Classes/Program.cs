namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
                var carone = new Car();
                carone.Make = "Toyota ";
                carone.Model = "Mazda";
                carone.Year = 2025;
                Console.WriteLine($"Make: {carone.Make} , {carone.Model} made in the year: {carone.Year}");
            }
        }
    }

