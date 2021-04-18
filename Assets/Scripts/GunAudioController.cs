using UnityEngine;

public class GunAudioController : MonoBehaviour
{
    [SerializeField] AudioClip weaponPickingUpSound;
    [SerializeField] AudioClip weaponShootingSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        MainLinks.Instance.GunAudio = this;
        MainLinks.Instance.OnPlayerPicksUpWeapon += PlayPickUpSound;
        MainLinks.Instance.OnPlayerShoots += PlayShootSound;
    }

    public void PlayPickUpSound()
    {
        audioSource.clip = weaponPickingUpSound;
        audioSource.Play();
    }

    public void PlayShootSound()
    {
        audioSource.clip = weaponShootingSound;
        audioSource.Play();
    }

    private void OnDisable()
    {
        MainLinks.Instance.OnPlayerPicksUpWeapon -= PlayPickUpSound;
        MainLinks.Instance.OnPlayerShoots -= PlayShootSound;
    }
}
