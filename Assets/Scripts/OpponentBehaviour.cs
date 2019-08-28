using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        if (GameObject.FindGameObjectsWithTag("Opponent").Length == 0)
        {
            GameManager.Instance.level++;
            Debug.Log(GameManager.Instance.level);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
