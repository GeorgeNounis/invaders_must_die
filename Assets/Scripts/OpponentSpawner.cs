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
        Spawn();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
    
    void Awake()
    {
        
    }

    void Spawn()
    {
        float _xWidth = 4.8f;
        float _yPos = 4.8f;
        float _xPos;
        int _opponentNumber = 6;
        int _opponentRows = 3;
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
