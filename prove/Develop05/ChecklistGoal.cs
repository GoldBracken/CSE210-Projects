public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _totalCompletions;

    private int _bonus;

    public ChecklistGoal(bool complete, int points, int bonus, string name, string description, int totalCompletions) : base(complete, points, name, description)
    {
        _totalCompletions = totalCompletions;
        _timesCompleted = 0;
        _bonus = bonus;
    }

    public override string DisplayGoal()
    {
        string goalString = "";
        if(GetCompleted())
        {
            goalString += "[ x ]";
        }
        else
        {
            goalString += "[ ]";
        }
        goalString += $" {GetName()} ({GetDescription()}) -- Currently Completed {_timesCompleted}/{_totalCompletions}";
        return goalString;
    }

    public override void CompletedTask()
    {
        if(_timesCompleted < _totalCompletions - 1)
        {
            _timesCompleted++;
        }
        else
        {
            if(GetCompleted() != true)
                {
                    _timesCompleted++;
                    SetCompleted(true);
                    AddPoints(_bonus);
                }
        }
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void GetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public int GetTimesCompleted()
    {
        return _bonus;
    }

    public void SetTimesCompleted(int timeCompleted)
    {
        _timesCompleted = timeCompleted;
    }

    public override string SaveGoal()
    {
        return $"ChecklistGoal:{GetCompleted()},{GetPoints()},{_bonus},{GetName()},{GetDescription()},{_totalCompletions},{_timesCompleted}";    
    }

    // public override void LoadGoal(string fileName)
    // {
        
    // }
}