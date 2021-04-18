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
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(sceneChanger.ChangeScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
}