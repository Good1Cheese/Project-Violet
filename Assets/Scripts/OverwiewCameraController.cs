using UnityEngine;

public class OverwiewCameraController : MonoBehaviour
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
        float mouseY = Input.GetAxis("Mouse X") * m_verticalMouseSensivity * Time.deltaTime;

        yRotation += mouseY;

        transform.localRotation = Quaternion.Euler(0, yRotation, 0);
    }
}
