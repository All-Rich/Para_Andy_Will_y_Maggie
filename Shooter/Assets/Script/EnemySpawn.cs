using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public UnManager poolManager;
    public Transform[] points;

    private void Awake()
    {
        poolManager.Initialize();

        for(int i = 0; i < poolManager.GetPoolLenght() ; i++)
        {
            GameObject enemy = poolManager.ActivateNextObject();
            enemy.GetComponent<Enemigo_2>().points = points;
        }

    }
    
}
