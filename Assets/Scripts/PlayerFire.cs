using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    float elapsedTime;
    ObjectPooler objectPooler;

    void Fire()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 0.1f)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space))
            {
                objectPooler.SpawnFromPool("PlayerBullet", transform.position, Quaternion.identity);

            }
            elapsedTime = 0;
        }
    }

    void Start()
    {
        elapsedTime = 0;
        objectPooler = ObjectPooler.Instance;
    }

    void FixedUpdate()
    {
        Fire();
    }
}