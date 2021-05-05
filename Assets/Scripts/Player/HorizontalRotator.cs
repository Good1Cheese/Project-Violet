using UnityEngine;

public class HorizontalRotator : MonoBehaviour
{
    [SerializeField] bool isComponentAttachedToCamera;
    [SerializeField] float mouseSensitivity;

    void Start()
    {
        if (isComponentAttachedToCamera)
        {
            MainLinks.Instance.Camera = gameObject;
        }
    }

    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);
    }

    void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}