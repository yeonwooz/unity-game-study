using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float rotationSpeed = 1.5f; 
    private Vector3 lastMousePosition;
    private bool isDragging = false;

    void Update()
    {
        // 마우스 클릭 시작 시점
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
            isDragging = true;
        }

        // 마우스 클릭 중
        if (Input.GetMouseButton(0) && isDragging)
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            lastMousePosition = Input.mousePosition;

            float rotationX = delta.x * rotationSpeed * Time.deltaTime;
            float rotationY = -delta.y * rotationSpeed * Time.deltaTime;

            // 회전 적용
            transform.Rotate(Vector3.up, rotationX, Space.World);
            transform.Rotate(Vector3.right, rotationY, Space.Self);
        }

        // 마우스 클릭 종료 시점
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }
}
