using UnityEngine;

// INHERITANCE
public class PurpleCube : Cube
{
    void Start()
    {
        color = "Purple";
    }

    // POLYMORPHISM
    public override void Move(float horizontalInput, float verticalInput)
    {
        base.Move(-horizontalInput, -verticalInput);
    }

    // POLYMORPHISM
    public override void Move(Vector3 position)
    {
        Vector3 direction = transform.position - position;
        rb.velocity = direction.normalized * speed;
    }

    // POLYMORPHISM
    public override void DisplayStatement()
    {
        base.DisplayStatement();
        cubeText.text += "I'm the rebel cube!";
    }
}