using UnityEngine;

public class Grabbable2 : MonoBehaviour
{
    private Camera mainCam;
    private bool isDraggable = false;
    private Vector3 offset;
    private float zCoord;

    private void Start()
    {
       mainCam = Camera.main;
    }

    private void OnMouseDown()
    {
        zCoord = mainCam.WorldToScreenPoint(transform.position).z;

        offset = transform.position - GetMouseWorldPos();

        isDraggable = true;
    }

    private void OnMouseUp()
    {
        isDraggable = false;
    }

    private void Update()
    {
        if (isDraggable)
        {
            transform.position = GetMouseWorldPos() + offset;
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoord;
        return mainCam.ScreenToWorldPoint(mousePoint);
    }
}
