using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    GunData_SO gunData;

    void Start()
    {
        gunData = MainLinks.Instance.PlayerGunData;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        MainLinks.Instance.OnPlayerShoots?.Invoke();
        Instantiate(gunData.bulletPrefab, MainLinks.Instance.Camera.transform.position, gunData.bulletPrefab.transform.rotation);
    }
}
