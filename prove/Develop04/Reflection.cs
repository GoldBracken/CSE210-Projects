public class Reflection : Mindfulness
{
    private List<string> _startPrompts = new List<string>();
    private List<string> _reflectionPrompts = new List<string>();

    public Reflection(int sessionTime) : base(sessionTime, "Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _startPrompts.Add("Think of a time when you stood up for someone else.");
        _startPrompts.Add("Think of a time when you did something really difficult.");
        _startPrompts.Add("Think of a time when you helped someone in need.");
        _startPrompts.Add("Think of a time when you did something truly selfless.");

        _reflectionPrompts.Add("Why was this experience meaningful to you?");
        _reflectionPrompts.Add("Have you ever done anything like this before?");
        _reflectionPrompts.Add("How did you get started?");
        _reflectionPrompts.Add("How did you feel when it was complete?");
        _reflectionPrompts.Add("What made this time different than other times when you were not as successful?");
        _reflectionPrompts.Add("What is your favorite thing about this experience");
        _reflectionPrompts.Add("What could you learn from this experience that applies to other situations?");
        _reflectionPrompts.Add("What did you learn about yourself through this experience?");
        _reflectionPrompts.Add("How can you keep this experience in mind in the future?");
    }

    public void ReflectionExercise()
    {
        Console.Clear();
        Random rand = new Random();
        int totalTime = GetSessionTime();
        Console.Clear();
        Console.Write("Prepare to begin...\n");
        Pause(3);
        Console.WriteLine(" ");
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {_startPrompts[rand.Next(0, _startPrompts.Count)]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.Clear();
        while(GetSessionTime() >= 10 && _reflectionPrompts.Count > 0)
        {
            int index = rand.Next(0, _reflectionPrompts.Count);
            Console.Write($"> {_reflectionPrompts[index]}");
            Pause(10);
            Console.Write("\n");
            _reflectionPrompts.RemoveAt(index);
        }
        EndingMessage(totalTime);
    }
}