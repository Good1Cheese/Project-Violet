using UnityEngine;

public class PlayerCameraRotator : MonoBehaviour
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
        float mouseY = Input.GetAxis("Mouse Y") * m_verticalMouseSensivity * Time.deltaTime;

        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(yRotation, 0, 0);
    }
}


