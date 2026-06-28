using System;
using System.Drawing;
using System.IO;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = -1;
        List<Goal> goals = new List<Goal>();
        int points = 0;
        EternalQuest user = new EternalQuest(goals, points);

        while (userChoice != 6)
        {
            Console.WriteLine($"\nYour current level is {user.GetLevel()}.");
            Console.WriteLine($"\nYou have {user.GetTotalPoints()} points.\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    int goalChoice = -1;
                    int pointsWorth = 0;
                    string name = "";
                    string description = "";
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine(" 1. Simple Goal");
                    Console.WriteLine(" 2. Eternal Goal");
                    Console.WriteLine(" 3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    goalChoice = int.Parse(Console.ReadLine());
                    if(goalChoice == 1)
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();
                        Console.Write("Please give a short of your goal: ");
                        description = Console.ReadLine();
                        Console.Write("How many points do you get for completing your goal? ");
                        pointsWorth = int.Parse(Console.ReadLine());
                        SimpleGoal simple = new SimpleGoal(false, pointsWorth, name, description);
                        goals.Add(simple);
                    }
                    else if(goalChoice == 2)
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();
                        Console.Write("Please give a short of your goal: ");
                        description = Console.ReadLine();
                        Console.Write("How many points do you get for completing your goal? ");
                        pointsWorth = int.Parse(Console.ReadLine());
                        EternalGoal eternal = new EternalGoal(false, pointsWorth, name, description);
                        goals.Add(eternal);
                    }
                    else
                    {
                        int completionsNeeded = 0;
                        int bonus = 0;
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();
                        Console.Write("Please give a short of your goal: ");
                        description = Console.ReadLine();
                        Console.Write("How many points do you get for completing your goal? ");
                        pointsWorth = int.Parse(Console.ReadLine());
                        Console.Write("How many times do you need to do this goal to gain a bonus? ");
                        completionsNeeded = int.Parse(Console.ReadLine());
                        Console.Write($"What is the bonus for completing it {completionsNeeded} times? ");
                        bonus = int.Parse(Console.ReadLine());
                        ChecklistGoal checklist = new ChecklistGoal(false, pointsWorth, bonus, name, description, completionsNeeded);
                        goals.Add(checklist);
                    }
                    break;

                case 2:
                    user.DisplayGoals();
                    break;
                case 3:
                    string fileName = "";
                    Console.Write("What is the filename name for the goal file? ");
                    fileName = Console.ReadLine();
                    user.SaveGoals(fileName);
                    break;
                case 4:
                    fileName = "";
                    Console.Write("What is the filename name for the goal file? ");
                    fileName = Console.ReadLine();
                    user.LoadGoals(fileName);
                    break;
                case 5:
                    int index = 0;
                    Console.WriteLine("The goals are: ");
                    user.DisplayGoals();
                    Console.Write("Which goal did you accomplish? ");
                    index = int.Parse(Console.ReadLine()) - 1;
                    if(!goals[index].GetCompleted())
                    {
                        goals[index].CompletedTask();
                        user.UpdateTotalPoints(goals[index].GetPoints());
                        Console.WriteLine($"Congratulations! You have earned {goals[index].GetPoints()} points!");
                        Console.WriteLine($"Your current score is {user.GetTotalPoints()} points.");
                    }
                    break;
                case 6:
                    break;
            }
                

        }
    }
}