using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Laser_SO", menuName = "ScriptableObjects/Weapon/EnemyWeapon/Laser")]
public class EnemyLaser_SO : ScriptableObject
{
    [SerializeField] float damage;
    public float Damage { get => damage; }
}
