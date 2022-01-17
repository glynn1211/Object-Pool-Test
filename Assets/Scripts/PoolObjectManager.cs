using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObjectManager: MonoBehaviour
{
    [SerializeField]
    int amountToSpawn;
    [SerializeField]
    GameObject objectToSpawn;

    public string objectTag;

    public int GetAmount()
    {
        return amountToSpawn;
    }
    public GameObject GetObject()
    {
        return objectToSpawn;
    }
}
