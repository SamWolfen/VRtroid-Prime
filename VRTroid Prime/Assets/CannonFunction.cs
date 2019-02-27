using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFunction : MonoBehaviour
{
    public GameObject LaserPool;
    

    int LaserPoolSize = 0;
    int LaserPoolCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        LaserPoolSize = LaserPool.GetComponent<PoolGenerator>().PoolObjectList.Capacity;
        //Debug.Log("Laser Pool Size: " + LaserPoolSize);
        Debug.Log("Controller list: " + Input.GetJoystickNames());

    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetButtonDown("Fire1")) /*|| (Input.GetButtonDown())*/)
        {
            Debug.Log("FIRING MAH LASER!!! " + LaserPool.GetComponent<PoolGenerator>().PoolObjectList[LaserPoolCounter].name);

            if (LaserPool.GetComponent<PoolGenerator>().PoolObjectList[LaserPoolCounter].activeSelf == false)
            {
                LaserPool.GetComponent<PoolGenerator>().PoolObjectList[LaserPoolCounter].SetActive(true);
            }
            else
            {
                LaserPool.GetComponent<PoolGenerator>().PoolObjectList[LaserPoolCounter].SetActive(false);
                LaserPool.GetComponent<PoolGenerator>().PoolObjectList[LaserPoolCounter].SetActive(true);
            }


            if(LaserPool.GetComponent<PoolGenerator>().SecondPool)
            { 
                

                if (LaserPool.GetComponent<PoolGenerator>().PoolObject2List[LaserPoolCounter].activeSelf == false)
                {
                    LaserPool.GetComponent<PoolGenerator>().PoolObject2List[LaserPoolCounter].SetActive(true);
                }
                else
                {
                    LaserPool.GetComponent<PoolGenerator>().PoolObject2List[LaserPoolCounter].SetActive(false);
                    LaserPool.GetComponent<PoolGenerator>().PoolObject2List[LaserPoolCounter].SetActive(true);
                }

            }

            LaserPoolCounter++;

            if (LaserPoolCounter >= LaserPoolSize)
            {
                LaserPoolCounter = 0;
            }
        }
    }

    
}
