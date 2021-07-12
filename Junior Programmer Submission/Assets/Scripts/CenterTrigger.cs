using UnityEngine;
using UnityEngine.UI;

public class CenterTrigger : MonoBehaviour
{
    [SerializeField] Text centerText;

    void OnTriggerEnter(Collider other)
    {
        Cube cube = other.GetComponent<Cube>();
        if(cube != null)
        {
            centerText.text = cube.color + " cube entered!";
        }
    }

    void OnTriggerExit(Collider other)
    {
        Cube cube = other.GetComponent<Cube>();
        if (cube != null)
        {
            centerText.text = cube.color + " cube left!";
        }
    }
}
