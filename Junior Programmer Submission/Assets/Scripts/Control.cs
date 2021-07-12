using UnityEngine;

public class Control : MonoBehaviour
{
    private Cube selectedCube = null;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleSelection();
        }
        else if (selectedCube != null)
        {
            HandleMovement();
        }
    }

    // ABSTRACTION
    void HandleSelection()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var cube = hit.collider.GetComponent<Cube>();
            if(cube != null)
            {
                selectedCube = cube;
                selectedCube.DisplayStatement();
            }
        }
    }

    // ABSTRACTION
    void HandleMovement()
    {
        if (Input.GetMouseButton(1))
        {
            ClickMove();
        }
        else
        {
            AxisMove();
        }
    }

    // ABSTRACTION
    void ClickMove()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            selectedCube.Move(hit.point);
        }
    }

    // ABSTRACTION
    void AxisMove()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        selectedCube.Move(horizontalInput, verticalInput);
    }
}