using UnityEngine;

public class EndGameController : MonoBehaviour
{
    void RestartGame()
    {
        StartCoroutine(MainLinks.Instance.SceneChanger.ChangeScene(0));
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Start()
    {
        MainLinks.Instance.OnEnemiesDied += RestartGame;
    }

    void OnDisable()
    {
        MainLinks.Instance.OnEnemiesDied -= RestartGame;
    }
}
