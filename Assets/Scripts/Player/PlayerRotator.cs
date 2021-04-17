using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
    [SerializeField] float mouseSensitivity;

    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);
    }
}