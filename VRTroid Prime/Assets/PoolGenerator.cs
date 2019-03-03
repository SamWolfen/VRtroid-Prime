﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolGenerator : MonoBehaviour {
    public GameObject Pool;
    public GameObject PoolObject;
    static int PoolSize = 10;
    public List<GameObject> PoolObjectList = new List<GameObject>(PoolSize);

    public bool SecondPool;
    public GameObject PoolObject2;
    public List<GameObject> PoolObject2List = new List<GameObject>(PoolSize);

    // Use this for initialization
    void Start () {
        int i = 0;

        while (i < PoolSize)
        {
            GameObject newPoolObject = Instantiate(PoolObject, transform);
            newPoolObject.SetActive(false);
            PoolObjectList.Add(newPoolObject);

            i++;
        }

        Debug.Log(Pool.name + " Complete, list size: " + PoolObjectList.Capacity);

        if (SecondPool == true)
        {
            Debug.Log("Creating second pool");

            i = 0;

            while (i < PoolSize)
            {
                GameObject newPoolObject = Instantiate(PoolObject2, transform);
                newPoolObject.SetActive(false);
                PoolObject2List.Add(newPoolObject);

                i++;
            }

            Debug.Log(Pool.name + " Complete, list size: " + PoolObjectList.Capacity);
        }
    }
	
	
}
