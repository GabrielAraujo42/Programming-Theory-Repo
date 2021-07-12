using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    // ENCAPSULATION
    public string color { get; protected set; }

    protected Rigidbody rb;
    protected Text cubeText;
    [SerializeField] protected float speed = 3f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        cubeText = GameObject.FindGameObjectWithTag("CubeText").GetComponent<Text>();
    }

    public virtual void Move(Vector3 position)
    {
        Vector3 direction = position - transform.position;
        rb.velocity = direction.normalized * speed;
    }

    public virtual void Move(float horizontalInput, float verticalInput)
    {
        Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput);
        rb.velocity = direction * speed;
    }

    public virtual void DisplayStatement()
    {
        cubeText.text = "Hi! I'm " + color + "!\n";
    }
}
