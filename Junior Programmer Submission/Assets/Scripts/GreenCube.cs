using UnityEngine;

public class GreenCube : Cube
{
    void Start()
    {
        color = "Green";
    }

    public override void DisplayStatement()
    {
        base.DisplayStatement();
        cubeText.text += "I'm the first cube!";
    }
}
