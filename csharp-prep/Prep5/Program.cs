using System;

class Program
{
    /*
        Writes "Welcome to the Program" to the console.
        Parameters: none
        returns: void
    */
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    /*
        Asks for users name and returns inputted string.
        Parameters: none
        returns: string name
    */
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    /*
        Asks for users favorite number and returns inputted int.
        Parameters: none
        returns: int num
    */
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    /*
        Asks for users birth year and set int x to inputted value.
        Parameters: out int x
        returns: void
    */
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    /*
        Squares the int passed as a parameter.
        Parameters: int i
        returns: int i
    */
    static int SquareNumber(int i)
    {
        i *= i;
        return i;
    }

    /*
        Display the user's name, squared number, and how many years old they will turn will turn.
        Parameters: string name, int i, int birthYr
        returns: void
    */
    static void DisplayResult(string name, int i, int birthYr)
    {
        Console.WriteLine($"{name}, the square of your number is {i}");
        int age = DateTime.Now.Year - birthYr;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    
    static void Main(string[] args)
    {
        int birthYear;

        DisplayWelcome();

        string name = PromptUserName();
        int favNum = PromptUserNumber();

        PromptUserBirthYear(out birthYear);

        int sqrNum = SquareNumber(favNum);
        DisplayResult(name, sqrNum, birthYear);
    }
}