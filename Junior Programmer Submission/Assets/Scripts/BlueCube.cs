using UnityEngine;

// INHERITANCE
public class BlueCube : Cube
{
    void Start()
    {
        color = "Blue";
    }

    // POLYMORPHISM
    public override void DisplayStatement()
    {
        base.DisplayStatement();
        cubeText.text += "I'm the faster cube!";
    }
}