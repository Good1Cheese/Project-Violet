using UnityEngine;

public class WeaponSlot : MonoBehaviour
{
    GameObject weapon;
    PlayerShooting playerShooting;

    public GameObject Weapon
    {
        get => weapon;
        set
        {
            weapon = value;
            weapon.transform.SetParent(transform);
            weapon.transform.position = transform.position;
            playerShooting.enabled = true;
        }
    }

    void Start()
    {
        MainLinks.Instance.PlayerWeaponSlot = this;
        playerShooting = GetComponent<PlayerShooting>();
    }
}
