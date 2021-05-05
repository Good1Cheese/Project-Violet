using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    float bulletSpeed;
    Vector3 flyDirection;

    void Start()
    {
        flyDirection = MainLinks.Instance.Camera.transform.forward;
        bulletSpeed = MainLinks.Instance.PlayerGunData.bulletSpeed;
    }

    void Update()
    {
        transform.Translate(flyDirection * bulletSpeed * Time.deltaTime);
    }
}
