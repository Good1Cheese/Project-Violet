using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    [Tooltip("Vertical sensitivy of camera")]
    [SerializeField] float m_verticalMouseSensivity;
    float yRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * m_verticalMouseSensivity * Time.deltaTime;

        yRotation += mouseX;

        transform.localRotation = Quaternion.Euler(0, yRotation, 0);
    }
}
