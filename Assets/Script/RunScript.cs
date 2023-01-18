
public class RunScript : Command
{
    public RunScript(Unit unit) : base(unit)
    {
    }



    public override void Execute(float movement, float coordinate)
    {
        _unit.Runner(movement, coordinate);
    }

    public override void Undo()
    {
        _unit.PreviousPosition();
    }
}



