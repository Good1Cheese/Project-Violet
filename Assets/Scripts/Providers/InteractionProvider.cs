using UnityEngine;

[RequireComponent(typeof(InteractionRayProviderRayProvider))]
public class InteractionProvider : MonoBehaviour, IProvider
{
    InteractionRayProviderRayProvider rayProvider;
    IInteractable interactable;

    void Start()
    {
        rayProvider = GetComponent<InteractionRayProviderRayProvider>();
        rayProvider = MainLinks.Instance.InteractionRayProviderRayProvider;
    }

    void Update()
    {
        Provide();
    }

    public void Provide()
    {
        if (interactable != null)
        {
            MainLinks.Instance.TextWriter.HideField();
        }

        RaycastHit hit = MainLinks.Instance.InteractionRayProviderRayProvider.hitableObject;
        bool isHitInteractive = (hit.collider != null) && hit.collider.gameObject.TryGetComponent(out interactable);
        if (!isHitInteractive) { return; }
            
        MainLinks.Instance.TextWriter.Write("нажмите [E], чтобы взаимодействовать");
        if (Input.GetKeyDown(KeyCode.E))
        {
            interactable.Interact();
        }


    }
}
