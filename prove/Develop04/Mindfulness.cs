using System.Threading.Tasks.Dataflow;

public class Mindfulness
{
    private int _sessionTime;
    private string _activityType;
    private string _description;

    public Mindfulness(int sessionTime, string activity, string description)
    {
        _sessionTime = sessionTime;
        _activityType = activity;
        _description = description;
    }

    public int GetSessionTime()
    {
        return _sessionTime;
    }

    public void SetSessionTime()
    {
        Console.Write("\nHow long would you like your session to be? (In seconds) ");
        _sessionTime = int.Parse(Console.ReadLine());
    }

    public void StartingMessage() {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _activityType);
        Console.WriteLine("\n" + _description);
        SetSessionTime();
    }

    public void EndingMessage(int time) {
        Console.WriteLine("\nWell done!");
        Pause(3);
        Console.WriteLine($"\nYou have completed another {time} seconds of the {_activityType}");
        Pause(3);
    }

    public void Countdown(int time) {
        for(int i = time; 0 < i; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        _sessionTime = _sessionTime - time;
    }

    public void Pause(int time)
    {
        DateTime endTime = DateTime.Now.AddSeconds(time);

        while(DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            _sessionTime--;
        }

    }
}