using UnityEngine;

public class EndGameController : MonoBehaviour
{
    void Start()
    {
        MainLinks.Instance.OnEnemiesDied += RestartGame;    
    }

    void RestartGame()
    {
        StartCoroutine(MainLinks.Instance.SceneChanger.ChangeScene(0));
        Cursor.lockState = CursorLockMode.None;
    }

    void OnDestroy()
    {
        MainLinks.Instance.OnEnemiesDied -= RestartGame;
    }
}
