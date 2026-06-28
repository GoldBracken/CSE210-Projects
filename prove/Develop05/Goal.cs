public abstract class Goal
{
    private bool _complete = false;
    private int _points; 
    private string _name = "";
    private string _description = "";

    public Goal(bool complete, int points, string name, string description)
    {
        _complete = complete;
        _points = points;
        _name = name;
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int x)
    {
        _points = x;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public bool GetCompleted()
    {
        return _complete;
    }

    public void SetCompleted(bool complete)
    {
        _complete = complete;
    }

    public void AddPoints(int n)
    {
        _points += n;
    }

    public abstract string DisplayGoal();
    public abstract void CompletedTask();
    public abstract string SaveGoal();
    //public abstract void LoadGoal(string fileName);

}