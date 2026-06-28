using System.IO;

public class EternalQuest
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;
    private int _level;

    public EternalQuest(List<Goal> goals, int totalPoints) {
        _goals = goals;
        _totalPoints = totalPoints;
        _level = 0;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void SetTotalPoints(int x)
    {
        _totalPoints = x;
    }

    public void UpdateTotalPoints(int points)
    {
        _totalPoints += points;
        _level = _totalPoints/100;
    }

    public int GetLevel()
    {
        return _level;
    }

    public void SetLevel(int x)
    {
        _level = x;
    }

    public void DisplayGoals()
    {
        for(int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].DisplayGoal()}");
        }
    }

    public void SaveGoals(string fileName)
    {
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalPoints);
            foreach(Goal goal in _goals)
            {
                if(goal.SaveGoal().Split(":")[0] == "SimpleGoal")
                {
                    outputFile.WriteLine(goal.SaveGoal());
                }
                else if(goal.SaveGoal().Split(":")[0] == "EternalGoal")
                {
                    outputFile.WriteLine(goal.SaveGoal());
                }
                else if(goal.SaveGoal().Split(":")[0] == "ChecklistGoal")
                {
                    outputFile.WriteLine(goal.SaveGoal());
                }
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _goals.Clear();
        _totalPoints = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();
        foreach (string line in lines)
        {
            string[] getGoal = line.Split(":");
            string[] variables = getGoal[1].Split(",");

            CreateGoal(getGoal[0], variables);
        }
    }

    public void CreateGoal(string goalType, string[] vars)
    {
        if(goalType == "SimpleGoal")
        {
            SimpleGoal simpleGoal = new SimpleGoal(bool.Parse(vars[0]), int.Parse(vars[1]), vars[2], vars[3]);
            _goals.Add(simpleGoal);
        }
        else if(goalType == "EternalGoal")
        {
             EternalGoal eternalGoal = new EternalGoal(bool.Parse(vars[0]), int.Parse(vars[1]), vars[2], vars[3]);
            _goals.Add(eternalGoal);
        }
        else if(goalType == "ChecklistGoal")
        {
            ChecklistGoal checklist = new ChecklistGoal(bool.Parse(vars[0]), int.Parse(vars[1]), int.Parse(vars[2]), vars[3], vars[4], int.Parse(vars[5]));
            checklist.SetTimesCompleted(int.Parse(vars[6]));
            _goals.Add(checklist);
        }
    }
}