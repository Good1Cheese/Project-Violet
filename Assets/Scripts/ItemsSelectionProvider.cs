using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsSelectionProvider : MonoBehaviour, IProvider
{
    RayProvider rayProvider;
    ISelectable selectable;


    void Start()
    {
        rayProvider = GetComponent<RayProvider>();
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

        RaycastHit hit = RayProvider.hitableObject;
        bool canHitBeSelected = hit.collider.gameObject.TryGetComponent(out selectable);
        if (canHitBeSelected)
        {
            selectable.Select();
        }

    }

}
