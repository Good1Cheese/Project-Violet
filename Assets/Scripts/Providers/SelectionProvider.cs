using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RayProvider))]
public class SelectionProvider : MonoBehaviour, IProvider
{
    ISelectable selectable;

    void Update()
    {
        Provide();
    }

    public void Provide()
    {
        if (selectable != null)
        {
            MainLinks.Instance.TextWriter.HideField();
            selectable.Deselect();
        }

        RaycastHit hit = MainLinks.Instance.InteractionRayProvider.HitableObject;
        if (hit.collider == null) { return; }

        selectable = hit.collider.gameObject.GetComponent<ISelectable>();
        if (selectable != null && selectable.enabled)
        {
            MainLinks.Instance.TextWriter.Write("нажмите [E], чтобы взаимодействовать");
            selectable.Select();
        }

    }

}
