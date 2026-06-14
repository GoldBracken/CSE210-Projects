public class Listening : Mindfulness
{
    private List<string> _prompts = new List<string>();

    public Listening(int sessionTime) : base(sessionTime, "Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void ListeningExercise()
    {
        Random rand = new Random();
        int totalTime = GetSessionTime();
        int itemsListed = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetSessionTime());
        
        Console.Clear();
        Console.Write("Prepare to begin...\n");
        Pause(3);
        Console.WriteLine(" ");
        Console.WriteLine("List as many responses as you can to the following question:");
        Console.WriteLine($" --- {_prompts[rand.Next(0, _prompts.Count)]} ---");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine(" ");
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemsListed++;
        }
        Console.WriteLine($"You listed {itemsListed} items!");
        EndingMessage(totalTime);
    }
}