using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    EnemyHealthContorller healthContorller;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        MainLinks.Instance.WeaponRayProviderRayProvider.Provide(out RaycastHit hit);
        bool isHitInteractive = (hit.collider != null) && hit.collider.gameObject.TryGetComponent(out healthContorller);
        if (!isHitInteractive) { return; }
        MainLinks.Instance.OnPlayerShoots.Invoke();

        healthContorller.GetDamage(10);
    }
}
