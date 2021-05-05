using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(InteractableItemSelectable))]
public class PCInteractable : MonoBehaviour, IInteractable
{
    MonoBehaviour selectionOfItem;
    [SerializeField] float IncreasedFov;
    HorizontalRotator overviewCameraScript;
    float startFov;

    void Start()
    {
        selectionOfItem = GetComponent<ISelectable>();
        startFov = Camera.main.fieldOfView;
        overviewCameraScript = MainLinks.Instance.Camera.GetComponent<HorizontalRotator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Camera.main.fieldOfView == IncreasedFov)
        {
            DeactiveAndActivateThings();
            Camera.main.fieldOfView = startFov;
        }
    }

    public void Interact()
    {
        DeactiveAndActivateThings();
        Camera.main.fieldOfView = IncreasedFov;
    }

    void DeactiveAndActivateThings()
    {
        selectionOfItem.enabled = !selectionOfItem.enabled;
        MainLinks.Instance.ProgramUI.SetActive(!MainLinks.Instance.ProgramUI.activeSelf);
        overviewCameraScript.enabled = !overviewCameraScript.enabled;
    }
}