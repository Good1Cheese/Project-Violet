using UnityEngine;

public class WeaponRayProviderRayProvider : MonoBehaviour
{
    public RaycastHit hitableObject;

    void Start()
    {
        MainLinks.Instance.WeaponRayProviderRayProvider = this;
    }

    public void Provide(out RaycastHit hit)
    {
        Ray rayToForward = new Ray(transform.position, transform.forward);
        Physics.Raycast(rayToForward, out hitableObject);
        hit = hitableObject;
    }

}
