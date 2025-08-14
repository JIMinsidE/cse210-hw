public abstract class Goal
{
    public string _shortname;
    public string _description;
    private int _points;

    public Goal(string shortname, string description, int points)
    {
        _shortname = shortname;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentasion();

    public virtual string GetDetails()
    {
        string status = IsComplete() ? "[x]" : "[ ]";
        return $"{status} {_shortName}  ({_description})";
    }    
}