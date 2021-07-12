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
        Debug.Log("I'm the first cube!");
    }
}
