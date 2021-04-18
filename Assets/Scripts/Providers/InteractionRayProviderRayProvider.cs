using System;
using UnityEngine;

public class InteractionRayProviderRayProvider : MonoBehaviour
{
    public RaycastHit hitableObject;

    void Start()
    {
        MainLinks.Instance.InteractionRayProviderRayProvider = this;    
    }

    void Update()
    {
        Provide(out hitableObject);    
    }

    public void Provide(out RaycastHit hit)
    {
        Ray rayToForward = new Ray(transform.position, transform.forward);
        Physics.Raycast(rayToForward, out hitableObject);
        hit = hitableObject;
    }


}
