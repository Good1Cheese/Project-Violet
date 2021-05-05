using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GunData))]
public class WeaponItemInteractable : MonoBehaviour, IInteractable
{
    void Start()
    {
        GunData_SO gunData_SO = GetComponent<GunData>().GunData_SO;
        if (gunData_SO == null)
        {
            Debug.LogError("Weapon doesnt have GunData Script!");
        }
        MainLinks.Instance.PlayerGunData = gunData_SO;
    }

    public void Interact()
    {
        MainLinks.Instance.PlayerWeaponSlot.Weapon = gameObject;
    }
}
