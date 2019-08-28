using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    float elapsedTime;
    ObjectPooler objectPooler;
    SoundManager soundManager;

    void Fire()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 0.1f)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space))
            {
                objectPooler.SpawnFromPool("PlayerBullet", transform.position, Quaternion.identity);
                soundManager.PlayerFire.Play();
            }
            elapsedTime = 0;
        }
    }

    void Start()
    {
        elapsedTime = 0;
        objectPooler = ObjectPooler.Instance;
        soundManager = SoundManager.Instance;
    }

    void FixedUpdate()
    {
        Fire();
    }
}