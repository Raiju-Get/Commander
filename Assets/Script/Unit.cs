using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    public Vector2 movementX = new Vector2(1,0);
    public Vector2  movementY = new Vector2(0, 1);
    public List<Vector2> currentPosition = new List<Vector2>();

    public ActionRecoder _actionRecoder;
  

   // Update is called once per frame
    void Update()
    {
        CommandExample();
    }

    private void CommandExample()
    {
        Command runCommand = new RunScript(this);
        if (Input.GetKeyDown(KeyCode.D))
        {
            _actionRecoder.Recorder(runCommand, movementX, transform.position);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _actionRecoder.Recorder(runCommand, -movementX, transform.position);
        }else if (Input.GetKeyDown(KeyCode.W))
        {
            _actionRecoder.Recorder(runCommand, movementY, transform.position);
        }else if (Input.GetKeyDown(KeyCode.S))
        {
            _actionRecoder.Recorder(runCommand, -movementY, transform.position);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            _actionRecoder.Undo();
        }
    }

    public void Runner(Vector2 runner, Vector2 currentCoordinate)
    {
       transform.Translate(new Vector3(runner.x,runner.y));
       currentPosition.Add(currentCoordinate);
    }

    public void PreviousPosition()
    {
        transform.position = new Vector2(currentPosition[currentPosition.Count-1].x,currentPosition[currentPosition.Count-1].y);
        currentPosition.RemoveAt(currentPosition.Count-1);
    }
   
}
