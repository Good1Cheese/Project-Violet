using UnityEngine;

public class EnemyLineProvider : MonoBehaviour
{
    RaycastHit hitableObject;
    public RaycastHit HitableObject { get => hitableObject; }

    void Update()
    {
        Provide();
    }

    void Provide()
    {
        Physics.Linecast(transform.position,
            MainLinks.Instance.Player.transform.position,
            out hitableObject);
    }
}
