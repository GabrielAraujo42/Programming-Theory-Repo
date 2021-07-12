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
            var cube = hit.collider.GetComponent<Cube>();
            if(cube != null)
            {
                selectedCube = cube;
                selectedCube.DisplayStatement();
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
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        selectedCube.Move(horizontalInput, verticalInput);
    }
}
