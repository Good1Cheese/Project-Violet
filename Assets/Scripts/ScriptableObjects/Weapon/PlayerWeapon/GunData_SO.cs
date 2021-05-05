using UnityEngine;

[CreateAssetMenu(fileName = "new GunData", menuName = "ScriptableObjects/Weapon/PlayerWeapon/GunData", order = 1)]
public class GunData_SO : ScriptableObject
{
    public float bulletSpeed;
    public GameObject bulletPrefab;
    public float flyLimit;
    public AudioClip weaponPickingUpSound;
    public AudioClip weaponShootingSound;
}
