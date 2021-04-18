using UnityEngine;

class EnemyHealthContorller : MonoBehaviour
{
    [SerializeField] int helth;
    public int Health { get => helth; }

    void Start()
    {
        MainLinks.Instance.EnemyCount++;
    }

    public void GetDamage(int damage)
    {
        helth -= damage;
        if (helth <= 0)
        {
            gameObject.SetActive(false);
            MainLinks.Instance.EnemyCount--;
        }
    }
}