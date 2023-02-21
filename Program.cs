
internal class Program
{
    public static void Main(string[] args)
    {
        Conversation();
    }

    static void Conversation()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}. How old are u?");
        bool isint = int.TryParse(Console.ReadLine(), out int age);
        while (!isint)
        {
            Console.WriteLine("Please Enter age in numbers. Try again.");
            isint = int.TryParse(Console.ReadLine(), out age);
        }
        Console.WriteLine($"{age} good. I was born in 2002 which makes me {DateTime.Today.Year - 2002} years old.");
    }
}
    
