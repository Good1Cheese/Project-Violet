using UnityEngine;

[RequireComponent(typeof(PlayerShooting))]
public class WeaponSlot : MonoBehaviour
{
    PlayerShooting playerShooting;
    GameObject weapon;

    public GameObject Weapon
    {
        get => weapon;
        set
        {
            weapon = value;
            MainLinks.Instance.OnPlayerPicksUpWeapon?.Invoke();
            weapon.transform.position = transform.position;
            weapon.transform.rotation = transform.rotation;
            weapon.transform.SetParent(transform);
            playerShooting.enabled = true;
        }
    }

    void Start()
    {
        MainLinks.Instance.PlayerWeaponSlot = this;
        playerShooting = GetComponent<PlayerShooting>();
    }   
}
