using System;
using UnityEngine;

public class MainLinks : MonoBehaviour
{
    public static MainLinks Instance;

    int enemyCount;
    public int EnemyCount
    {
        get { return enemyCount; }
        set
        {
            enemyCount = value;
            if(enemyCount == 0)
            {
                OnEnemiesDied.Invoke();
            }
        }

    }

    public GunAudioController GunAudio { get; set; }
    public WeaponSlot PlayerWeaponSlot { get; set; }
    public UITextWriter TextWriter { get; set; }
    public InteractionRayProviderRayProvider InteractionRayProviderRayProvider { get; set; }
    public WeaponRayProviderRayProvider WeaponRayProviderRayProvider { get; set; }
    public SceneChanger SceneChanger { get; set; }
    public Action OnEnemiesDied { get; set; }
    public Action OnPlayerShoots { get; set; }
    public Action OnPlayerPicksUpWeapon { get; set; }
    public Action OnEnemyDie { get; set; }

    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There are more then 1 MainLinks's Instance");
        }
        Instance = this;
    }
}
