using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : PoolObjectManager
{

     
    private void Awake()
    {
        
    }

    private void Start()
    {
        objectTag = "Enemy";
    }

    public void SpawnEnemy()
    {
        GameObject enemy = PoolManager.Instance.GetPoolObject(objectTag);
        if(enemy != null)
        {
            enemy.SetActive(true);
        }
    }

    public void DespawnEnemy(GameObject enemy)
    {
        enemy.SetActive(false);
    }
}
