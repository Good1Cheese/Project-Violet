using UnityEngine;

public class VerticalRotator : MonoBehaviour
{
    [SerializeField] float m_verticalMouseSensivity;
    float yRotation;

    void Start()
    {
        MainLinks.Instance.Camera = gameObject;
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


