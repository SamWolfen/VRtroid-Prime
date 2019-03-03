using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserBehaviour : MonoBehaviour {
    public GameObject Lasers;
    public GameObject Plane;
    public GameObject Muzzle;
    public GameObject Debugger;
    Rigidbody m_Rigidbody;
    public float speed;
    Transform LocalZero;
    public float Lifetime;
    float initLifetime = 0;
    private void OnEnable()
    {
        Debug.Log("enabled");
        StartCoroutine(BulletLife());
        LocalZero = Muzzle.transform;
        Lasers.transform.position = LocalZero.position;
        Lasers.transform.rotation = LocalZero.rotation;
        try
        {
            m_Rigidbody.velocity = transform.forward * speed;
        }
        catch { };

    }

    // Use this for initialization
    void Start () {
        transform.position.Set(0.0f, 0.0f, 0.0f);
        initLifetime = Lifetime;
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.velocity = transform.forward * speed;
    }

    private void Awake()
    {
        
    }



    // Update is called once per frame
    IEnumerator BulletLife()
    {
        bool loop = true;

        while (loop)
        {
            yield return new WaitForSecondsRealtime(1f);
            if (Lifetime > 0)
            {
                Lifetime -= (Time.deltaTime); ;
            }
            else
            {
                Debugger.GetComponent<DebugInfo>().BulletsActive--;
                Lifetime = initLifetime;
                gameObject.SetActive(false);
                loop = false;
            }
            //Debug.Log("Velo of " + gameObject.name + ": " + m_Rigidbody.velocity);
            LocalZero = Plane.transform;
        }
	}
}
