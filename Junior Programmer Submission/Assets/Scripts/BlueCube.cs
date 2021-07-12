using UnityEngine;

public class BlueCube : Cube
{
    void Start()
    {
        color = "Blue";
    }

    public override void DisplayStatement()
    {
        base.DisplayStatement();
        cubeText.text += "I'm the faster cube!";
    }
}