namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            User user = new User();
            user.createUser("Daan");
            user.createUser("Selcuk");
        }
    }
}
