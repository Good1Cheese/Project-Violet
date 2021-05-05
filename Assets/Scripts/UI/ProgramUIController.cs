using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgramUIController : MonoBehaviour
{
    SceneChanger sceneChanger;
    int nextSceneIndex;

    void Start()
    {
        MainLinks.Instance.ProgramUI = transform.GetChild(0).gameObject;
        sceneChanger = MainLinks.Instance.SceneChanger;
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void StartScaning()
    {
        StartCoroutine(sceneChanger.ChangeScene(nextSceneIndex));
    }
}
