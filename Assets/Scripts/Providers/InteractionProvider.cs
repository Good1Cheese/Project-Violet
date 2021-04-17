using UnityEngine;

public class InteractionProvider : MonoBehaviour, IProvider
{
    RayProvider rayProvider;
    IInteractable interactable;

    void Start()
    {
        rayProvider = GetComponent<RayProvider>();
        rayProvider = MainLinks.Instance.RayProvider;
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

        Debug.DrawRay(transform.position, transform.forward, Color.red);
        RaycastHit hit = RayProvider.hitableObject;
        bool isHitInteractive = (hit.collider != null) && hit.collider.gameObject.TryGetComponent(out interactable);
        if (!isHitInteractive) { return; }
            
        MainLinks.Instance.TextWriter.Write("нажмите [E], чтобы взаимодействовать");
        if (Input.GetKeyDown(KeyCode.E))
        {
            interactable.Interact();
        }


    }
}
