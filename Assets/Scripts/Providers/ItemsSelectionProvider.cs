using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InteractionRayProviderRayProvider))]
public class ItemsSelectionProvider : MonoBehaviour, IProvider
{
    InteractionRayProviderRayProvider rayProvider;
    ISelectable selectable;


    void Start()
    {
        rayProvider = GetComponent<InteractionRayProviderRayProvider>();
    }

    void Update()
    {
        Provide();
    }

    public void Provide()
    {
        if (selectable != null)
        {
            selectable.Deselect();
        }

        RaycastHit hit = rayProvider.hitableObject;
        bool canHitBeSelected = (hit.collider != null) && hit.collider.gameObject.TryGetComponent(out selectable);
        if (canHitBeSelected)
        {
            selectable.Select();
        }

    }

}
