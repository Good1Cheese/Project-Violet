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
            if (enemyCount == 0)
            {
                OnEnemiesDied?.Invoke();
            }
        }

    }

    public GameObject Camera { get; set; }
    public WeaponSlot PlayerWeaponSlot { get; set; }
    public UITextWriter TextWriter { get; set; }
    public RayProvider InteractionRayProvider { get; set; }
    public SceneChanger SceneChanger { get; set; }
    public Action OnEnemiesDied { get; set; }
    public Action OnPlayerShoots { get; set; }
    public Action OnPlayerPicksUpWeapon { get; set; }
    public GameObject ProgramUI { get; set; }
    public GameObject Player { get; set; }
    public GunData_SO PlayerGunData { get; set; }
    public HealthController PlayerHealthController { get; internal set; }

    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There are more then 1 MainLinks's Instance");
        }
        Instance = this;
    }

    void Start()
    {
        PlayerHealthController = Player.GetComponent<HealthController>();
    }

    void OnDestroy()
    {
        Instance = null;
    }
}
