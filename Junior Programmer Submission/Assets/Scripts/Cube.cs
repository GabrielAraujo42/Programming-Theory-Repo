using UnityEngine;

public class Cube : MonoBehaviour
{
    public string color { get; protected set; }

    protected Rigidbody rb;
    [SerializeField] protected float speed = 3f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
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
        Debug.Log("Hi! I'm " + color + "!");
    }
}
