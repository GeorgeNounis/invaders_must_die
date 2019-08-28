using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentBulletMovement : MonoBehaviour
{
    void Movement()
    {
        Vector2 _temp;
        _temp = transform.position;
        _temp.y = transform.position.y + (-5 * Time.deltaTime);
        transform.position = _temp;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }
}
