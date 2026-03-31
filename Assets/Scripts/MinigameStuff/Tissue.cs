using UnityEngine;

public class Tissue : MonoBehaviour
{
    private Vector3 mousePositionO;

    void OnMouseDown()
    {
        mousePositionO = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
    }
    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z)) + mousePositionO;
    }
}
