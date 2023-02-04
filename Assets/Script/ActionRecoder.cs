using System.Collections.Generic;
using UnityEngine;

public class ActionRecoder : MonoBehaviour
{
   public readonly Stack<Command> commandList = new Stack<Command>();  
   public void Recorder(Command command, Vector2 movement, Vector2 coordinate)
   {
      commandList.Push(command);
      command.Execute(movement,coordinate);
   }

   public void Undo()
   {
      if (commandList.Count <=0)
      {
         return;
      }
      Command command = commandList.Pop();
      command.Undo();
      
   }
}
