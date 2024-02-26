namespace GreetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter the total number of your enrolled courses: ");
            int totalcourses;
            totalcourses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of your favorite book");
            double price;
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total number of enrolled courses: " + totalcourses);
            Console.WriteLine("Price of my favorite book: " + price);

        }
    }
}