

public class JumpScript : Command
{
    public JumpScript(Unit unit) : base(unit)
    {
    }


    public override void Execute(float movement, float coordinate)
    {
        throw new System.NotImplementedException();
    }

    public override void Undo()
    {
        throw new System.NotImplementedException();
    }
}
