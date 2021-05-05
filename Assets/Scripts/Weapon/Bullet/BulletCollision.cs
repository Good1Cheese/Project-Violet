using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        HealthController healthContorller = collision.collider.gameObject.GetComponent<HealthController>();
        if (healthContorller != null)
        {
            healthContorller.Damage(10);
        }
        Destroy(gameObject);
    }
}
