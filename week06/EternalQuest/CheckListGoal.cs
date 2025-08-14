using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}|{_amountCompleted}";
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[x]" : "[ ]";
        return $"{status} {_shortName}  ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }
    public bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

}