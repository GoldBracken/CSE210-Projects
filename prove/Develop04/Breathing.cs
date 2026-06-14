public class Breathing : Mindfulness
{
    public Breathing(int sessionTime) : base(sessionTime, "Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    public void BreathingExercise()
    {
        int totalTime = GetSessionTime();
        Console.Clear();
        Console.Write("Prepare to begin...\n");
        Pause(3);
        while(GetSessionTime() > 0)
        {
            
            if(GetSessionTime() > 10)
            {
                Console.Write("\nBreathe in...");
                Countdown(4);
                Console.Write("\nNow breathe out...");
                Countdown(6);
                Console.WriteLine(" ");
            }
            else
            {
                Console.Write("\nBreathe in...");
                Countdown(GetSessionTime()/2);
                Console.Write("\nNow breathe out...");
                if(GetSessionTime()%2 == 1)
                {
                    Countdown(GetSessionTime() + 1);
                    Console.WriteLine(" ");
                }
                else
                {
                    Countdown(GetSessionTime());
                    Console.WriteLine(" ");
                }
            }
            
        }
        EndingMessage(totalTime);
    }
}