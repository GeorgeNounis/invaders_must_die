using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentFire : MonoBehaviour
{
    float elapsedTime;
    int spawnTime;
    ObjectPooler objectPooler;

    void Fire()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= spawnTime)
        {
            objectPooler.SpawnFromPool("OpponentBullet", transform.position, Quaternion.identity);
            elapsedTime = 0;
        }
    }

    void Start()
    {
        spawnTime = Random.Range(1, 4);
        elapsedTime = 0;
        objectPooler = ObjectPooler.Instance;
    }

    void FixedUpdate()
    {
        Fire();
    }
}
