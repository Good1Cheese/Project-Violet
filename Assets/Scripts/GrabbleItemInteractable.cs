using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbleItemInteractable : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        MainLinks.Instance.PlayerWeaponSlot.Weapon = gameObject;
        MainLinks.Instance.OnPlayerPicksUpWeapon();
    }
}
