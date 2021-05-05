using UnityEngine;

public class RayProvider : MonoBehaviour
{
    RaycastHit hitableObject;
    public RaycastHit HitableObject { get => hitableObject; }

    void Start()
    {
        MainLinks.Instance.InteractionRayProvider = this;
    }

    void Update()
    {
        Provide();
    }

    void Provide()
    {
        Ray rayToForward = new Ray(transform.position, transform.forward);
        Physics.Raycast(rayToForward, out hitableObject);
    }
}
