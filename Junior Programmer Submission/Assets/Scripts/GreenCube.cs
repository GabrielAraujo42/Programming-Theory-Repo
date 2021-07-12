using UnityEngine;

// INHERITANCE
public class GreenCube : Cube
{
    void Start()
    {
        color = "Green";
    }

    // POLYMORPHISM
    public override void DisplayStatement()
    {
        base.DisplayStatement();
        cubeText.text += "I'm the first cube!";
    }
}