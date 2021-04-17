using UnityEngine;
using UnityEngine.SceneManagement;

public class PCInteractable : MonoBehaviour, IInteractable
{
    SceneChanger sceneChanger;

    void Start()
    {
        sceneChanger = MainLinks.Instance.SceneChanger;
    }

    public void Interact()
    {
        StartCoroutine(sceneChanger.ChangeScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
}