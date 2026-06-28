public class SimpleGoal : Goal
{
    public SimpleGoal(bool complete, int points, string name, string description) : base(complete, points, name, description)
    {
        
    }

    public override void CompletedTask()
    {
        if(GetCompleted() != true)
        {
            SetCompleted(true);
        }
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
        goalString += $" {GetName()} ({GetDescription()})";
        return goalString;
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal:{GetCompleted()},{GetPoints()},{GetName()},{GetDescription()}";
    }
    //public override void LoadGoal(string fileName)
    //{
        
    //}
}