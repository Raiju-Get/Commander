using System.Collections.Generic;
using UnityEngine;
public abstract class Command
{
    protected readonly Unit _unit;

    public Command(Unit unit)
    {
        _unit = unit;
    }

    public abstract void Execute(Vector2 movement, Vector2 coordinate);
    public abstract void Undo();
}
