using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentBehaviour : MonoBehaviour
{

    SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = SoundManager.Instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        soundManager.OpponentExplosion.Play();
        gameObject.SetActive(false);

        if (GameObject.FindGameObjectsWithTag("Opponent").Length == 0)
        {
            GameManager.Instance.level++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
