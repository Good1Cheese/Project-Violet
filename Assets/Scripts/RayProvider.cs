using UnityEngine;

public class RayProvider : MonoBehaviour
{
    public static RaycastHit hitableObject;

    void Update()
    {
        Provide(out hitableObject);
    }

    public void Provide(out RaycastHit hit)
    {
        Ray rayToForward = new Ray(transform.position, transform.forward);
        bool raycast = Physics.Raycast(rayToForward, out hitableObject);
        hit = hitableObject;
    }
}
