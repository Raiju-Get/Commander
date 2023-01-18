public abstract class Command
{
    protected readonly Unit _unit;

    public Command(Unit unit)
    {
        _unit = unit;
    }

    public abstract void Execute(float movement, float coordinate);
    public abstract void Undo();
}
