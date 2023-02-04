using System.Collections.Generic;
using UnityEngine;
public class RunScript : Command
{
    public RunScript(Unit unit) : base(unit)
    {
    }



    public override void Execute(Vector2 movement, Vector2 coordinate)
    {
        _unit.Runner(movement, coordinate);
        
    }

    public override void Undo()
    {
        _unit.PreviousPosition();
    }
}



