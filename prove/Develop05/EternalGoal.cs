public class EternalGoal : Goal
{
    public EternalGoal(bool complete, int points, string name, string description) : base(complete, points, name, description)
    {

    }

    public override string DisplayGoal()
    {
        string goalString = "";
        goalString += "[ ]";
        goalString += $" {GetName()} ({GetDescription()})";
        return goalString;
    }

    public override void CompletedTask()
    {
        
    }

    public override string SaveGoal()
    {
        return $"EternalGoal:{GetCompleted()},{GetPoints()},{GetName()},{GetDescription()}";
    }
    

    // public override void LoadGoal(string fileName)
    // {
        
    // }
}