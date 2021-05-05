using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] float health;
    public float Health { get => health; }

    public void Damage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }

}
