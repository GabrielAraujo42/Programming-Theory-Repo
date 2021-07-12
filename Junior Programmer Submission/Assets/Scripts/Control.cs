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

    void HandleSelection()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Cube cube = hit.collider.GetComponent<Cube>();
            if(cube != null)
            {
                selectedCube = cube;
            }
        }
    }

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

    void ClickMove()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            selectedCube.Move(hit.point);
        }
    }

    void AxisMove()
    {
        float horizontalInput, verticalInput;
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        selectedCube.Move(horizontalInput, verticalInput);
    }
}
