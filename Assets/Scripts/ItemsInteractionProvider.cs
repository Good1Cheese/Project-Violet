using UnityEngine;

public class ItemsInteractionProvider : MonoBehaviour, IProvider
{
    RayProvider rayProvider;
    IInteractable interactable;

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
        if (interactable != null)
        {
            MainLinks.Instance.TextWriter.HideField();
        }

        RaycastHit hit = RayProvider.hitableObject;
        bool isHitInteractive = hit.collider.gameObject.TryGetComponent(out interactable);
        if (!isHitInteractive) { return; }

        MainLinks.Instance.TextWriter.Write("нажмите [E], чтобы взаимодействовать");
        if (Input.GetKeyDown(KeyCode.E))
        {
            interactable.Interact();
        }


    }
}
