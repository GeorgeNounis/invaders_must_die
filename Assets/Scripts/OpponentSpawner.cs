using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentSpawner : MonoBehaviour
{

    ObjectPooler objectPooler;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.Instance;
        Spawn(5,1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameObject.FindGameObjectsWithTag("Opponent").Length == 0)
        {
            Spawn(5, GameManager.Instance.level);
        }
    }
    
    void Awake()
    {
        
    }

    public void Spawn(int _opponentNumber, int _opponentRows)
    {
        float _xWidth = 4.8f;
        float _yPos = 4.5f;
        float _xPos;
        float _stepY = 0.5f;
        float _stepX = _xWidth / (_opponentNumber - 1);

        for (int r = 0; r < _opponentRows; r++)
        {
            for (int i = 0; i < _opponentNumber; i++)
            {
                _xPos = (i * _stepX) -2.4f ;
                objectPooler.SpawnFromPool("Opponent", new Vector2((_xPos) , _yPos), Quaternion.identity);
            }
            _yPos -= _stepY;
        }
    }
}
