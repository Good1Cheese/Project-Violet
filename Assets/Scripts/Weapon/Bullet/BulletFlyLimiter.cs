using System;
using UnityEngine;

public class BulletFlyLimiter : MonoBehaviour
{
    float flyLimit;
    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        flyLimit = MainLinks.Instance.PlayerGunData.flyLimit;
    }

    void Update()
    {
        if (FindDifference(startPosition, transform.position) >= flyLimit)
        {
            gameObject.SetActive(false);
        }
    }

    float FindDifference(Vector3 startPosition, Vector3 position)
    {
        float firstValue = (startPosition.x + startPosition.y + startPosition.z);
        float secondValue = (position.x + position.y + position.z);
        return secondValue - firstValue;
    }
}
