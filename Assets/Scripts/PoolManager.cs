using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] pooledObjects;

    private Dictionary<string, List<GameObject>> pools = new Dictionary<string, List<GameObject>>();

    private void Start()
    {
        List<GameObject> poolItems = new List<GameObject>();
        GameObject go;
        string objectName = "";
        foreach (GameObject item in pooledObjects)
        {
            PoolObjectManager itemManager = item.GetComponent<PoolObjectManager>();
            for (int i = 0; i < itemManager.GetAmount(); i++)
            {
                go = Instantiate(itemManager.GetObject(),item.transform);
                go.SetActive(false);
                poolItems.Add(item);
                objectName = go.name;
            }
            pools.Add(objectName, poolItems);
            poolItems.Clear();
        }
    }

    public GameObject GetPoolObject(string objectTag)
    {
        if(pools.ContainsKey(objectTag))
        {
            for (int i = 0; i < pools[objectTag].Count; i++)
            {
                if(!pools[objectTag][i].activeInHierarchy)
                {
                    return pools[objectTag][i];
                }
            }
        }
            return null;
    }
}
