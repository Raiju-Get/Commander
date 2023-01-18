using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    public float movement = 1;
    public List<float> currentPosition = new List<float>();

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
            _actionRecoder.Recorder(runCommand, movement, transform.position.x);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _actionRecoder.Recorder(runCommand, -movement, transform.position.x);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            _actionRecoder.Undo(movement);
        }
    }

    public void Runner(float runner, float currentCoordinate)
    {
       transform.Translate(new Vector3(runner,0));
       currentPosition.Add(currentCoordinate);
    }

    public void PreviousPosition()
    {
        transform.position = new Vector2(currentPosition[currentPosition.Count-1], 0);
        currentPosition.RemoveAt(currentPosition.Count-1);
    }
   
}
