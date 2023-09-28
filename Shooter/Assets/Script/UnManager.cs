 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UnManager : MonoBehaviour
{
    private List<GameObject> pool;
    public GameObject pooledObject;
    public int amount;

    public void Initialize()
    {
        pool= new List<GameObject>();

        for(int i=0; i<amount; i++) 
        { 
            GameObject obj= Instantiate(pooledObject, transform.position, Quaternion.identity, transform);
            
            obj.SetActive(false);
            pool.Add(obj);
        
        }
    }

    public GameObject ActivateNextObject()
    {
        foreach (var objpool in pool)
        {
            if(!objpool.activeInHierarchy)
            {
                objpool.SetActive(true);
                return objpool;
            }
        }

        return null;
    }

    public void ActivateNextObject(float xPosition, float zPosition)
    {
        foreach (var objpool in pool)
        {
            if (!objpool.activeInHierarchy)
            {
                objpool.transform.position = new Vector3(xPosition, 0f, zPosition);
                objpool.SetActive(true);
                break;
            }
        }
    }

    public int GetPoolLenght()
    {
        return pool.Count;
    }

    public void DestroyObject(GameObject obj)
    {
        foreach (var objpool in pool)
        {
            if (objpool==obj)
            {
                objpool.SetActive(false);
            }
        }
    }

}
