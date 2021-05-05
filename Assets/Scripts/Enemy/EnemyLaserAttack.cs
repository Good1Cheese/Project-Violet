using UnityEngine;

[RequireComponent(typeof(LineRenderer), typeof(EnemyLineProvider))]
public class EnemyLaserAttack : MonoBehaviour
{
    [SerializeField] EnemyLaser_SO enemyLaser_SO;
    LineRenderer lineRenderer;
    EnemyLineProvider lineProvider;

    void Start()
    {
        lineProvider = GetComponent<EnemyLineProvider>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        Collider collider = lineProvider.HitableObject.collider;
        if (collider == null) { return; }
        if (collider.gameObject == MainLinks.Instance.Player)
        {
            NavigateLaser();
            MainLinks.Instance.PlayerHealthController.Damage(enemyLaser_SO.Damage);
        }
    }

    void NavigateLaser()
    {
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, MainLinks.Instance.Player.transform.position);
    }
}
