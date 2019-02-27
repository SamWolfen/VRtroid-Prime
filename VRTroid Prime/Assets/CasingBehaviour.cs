using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasingBehaviour : MonoBehaviour
{

    public GameObject EjectionPort;
    Rigidbody m_Rigidbody;
    Transform LocalZero;
    public float Lifetime;
    float initLifetime = 0;

    private void OnEnable()
    {
        initLifetime = Lifetime;
        LocalZero = EjectionPort.transform;
        this.gameObject.transform.position = LocalZero.position;
        this.gameObject.transform.rotation = LocalZero.rotation;


        try
        {
            m_Rigidbody.velocity = new Vector3 (1f, 1f, 0f);
            //m_Rigidbody.angularVelocity = new Vector3(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
        }
        catch { };

    }


    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Lifetime > 0)
        {
            Lifetime -= (Time.deltaTime); ;
        }
        else
        {
            Lifetime = initLifetime;
            gameObject.SetActive(false);
        }
    }
}
