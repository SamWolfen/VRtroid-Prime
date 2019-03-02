using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour
{
    public float  BulletsFired, BulletActive;
    public bool Magnet;
    public GameObject TextDisplay;
    private string text;

    // Start is called before the first frame update
    void Start()
    {
        text =TextDisplay.GetComponent<Text>().text;
    }

    // Update is called once per frame
    void Update()
    {



        text =
            "Debug Console \r\n" +
            "Magnet = " + Magnet + " \r\n" +
            "Bullets Fired = " + BulletsFired + " \r\n" +
            "Bullets Active = " + BulletActive;






        TextDisplay.GetComponent<Text>().text = text;
    }
}
