using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject gameOver;

    void Movement()
    {
        Vector2 _temp;
        _temp = transform.position;

        if (Input.GetKey(KeyCode.RightArrow)) {
            _temp.x = transform.position.x + (5 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _temp.x = transform.position.x - (5 * Time.deltaTime);
        }

        if (_temp.x >= -2.6f && _temp.x <= 2.6f) {
            transform.position = _temp;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        //gameObject.SetActive(false);
        Time.timeScale = 0;
        gameOver.gameObject.SetActive(true);

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
