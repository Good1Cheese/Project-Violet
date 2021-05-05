using UnityEngine;

class EnemyHealthController : HealthController
{
    void Start()
    {
        MainLinks.Instance.EnemyCount++;
    }

    void OnDisable()
    {
        if (MainLinks.Instance != null)
        {
            MainLinks.Instance.EnemyCount--;
        }
    }
}