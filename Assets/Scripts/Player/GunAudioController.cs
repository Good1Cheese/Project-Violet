using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class GunAudioController : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        MainLinks.Instance.OnPlayerPicksUpWeapon += PlayPickUpSound;
        MainLinks.Instance.OnPlayerShoots += PlayShootSound;
    }

    void PlayPickUpSound()
    {
        audioSource.clip = MainLinks.Instance.PlayerGunData.weaponPickingUpSound;
        audioSource.Play();
    }

    void PlayShootSound()
    {
        audioSource.clip = MainLinks.Instance.PlayerGunData.weaponShootingSound;
        audioSource.Play();
    }

    void OnDisable()
    {
        if (MainLinks.Instance != null)
        {
            MainLinks.Instance.OnPlayerPicksUpWeapon -= PlayPickUpSound;
            MainLinks.Instance.OnPlayerShoots -= PlayShootSound;
        }
    }
}
