using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float rotationSpeed = 3.0f; 
    private Vector3 lastMousePosition;

    void Update()
    {
        if (Input.GetMouseButton(0))  
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;  // 마우스 이동량 계산
            lastMousePosition = Input.mousePosition;

            float rotationX = delta.x * rotationSpeed * Time.deltaTime; 
            float rotationY = -delta.y * rotationSpeed * Time.deltaTime; 

            transform.Rotate(Vector3.up, rotationX, Space.World);  
            transform.Rotate(Vector3.right, rotationY, Space.Self); 
        }
        else
        {
            lastMousePosition = Input.mousePosition;
        }
    }
}
