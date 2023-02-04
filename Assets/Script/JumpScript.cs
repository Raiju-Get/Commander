using System.Collections.Generic;
using UnityEngine;

public class JumpScript : Command
{
    public JumpScript(Unit unit) : base(unit)
    {
    }


    public override void Execute(Vector2 movement, Vector2 coordinate)
    {
        throw new System.NotImplementedException();
    }

    public override void Undo()
    {
        throw new System.NotImplementedException();
    }
}
