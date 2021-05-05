using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class SceneChanger : MonoBehaviour
{
    Animator animator;

    void Awake()
    {
        MainLinks.Instance.SceneChanger = this;
        animator = GetComponent<Animator>();
    }

    public IEnumerator ChangeScene(int index)
    {
        animator.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(index);
        MainLinks.Instance.TextWriter.HideField();
    }

}
