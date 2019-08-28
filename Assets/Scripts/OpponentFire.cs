using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentFire : MonoBehaviour
{
    float elapsedTime;
    float spawnTime;
    ObjectPooler objectPooler;
    SoundManager soundManager;

    void Fire()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= spawnTime)
        {
            objectPooler.SpawnFromPool("OpponentBullet", transform.position, Quaternion.identity);
            soundManager.OpponentFire.Play();
            elapsedTime = 0;
        }
    }

    void Start()
    {
        spawnTime = Random.Range(1f, 5f);
        elapsedTime = 0;
        objectPooler = ObjectPooler.Instance;
        soundManager = SoundManager.Instance;
    }

    void FixedUpdate()
    {
        Fire();
    }
}
