using FormattingEx.Models;

namespace FormattingEx;

class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        Console.WriteLine("Hello user. What is your name?");
        Menu.StartMenu(Console.ReadLine());
        Console.ReadLine();
    }
}

