using UnityEngine;

[RequireComponent(typeof(RayProvider))]
public class InteractionProvider : MonoBehaviour, IProvider
{
    IInteractable interactable;

    void Update()
    {
        Provide();
    }

    public void Provide()
    {
        RaycastHit hit = MainLinks.Instance.InteractionRayProvider.HitableObject;
        if (hit.collider == null) { return; }

        bool isHitInteractive = hit.collider.gameObject.TryGetComponent(out interactable); 
        if (Input.GetKeyDown(KeyCode.E) && isHitInteractive)
        {
            interactable.Interact();
        }

    }
}
