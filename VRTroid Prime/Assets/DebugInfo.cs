using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour
{
    public float  BulletsFired, BulletsActive;
    public bool Magnet;
    public GameObject TextDisplay;
    private string text;

    IEnumerator TextUpdate()
    {
        bool loop = true;

        while (loop)
        {
            yield return new WaitForSecondsRealtime(1f);

            text =
                "Debug Console \r\n" +
                "Magnet = " + Magnet + " \r\n" +
                "Bullets Fired = " + BulletsFired + " \r\n" +
                "Bullets Active = " + BulletsActive;






            TextDisplay.GetComponent<Text>().text = text;


            
        }
        yield return null;
    }

    // Start is called before the first frame update
    void Start()
    {
        text = TextDisplay.GetComponent<Text>().text;
        StartCoroutine(TextUpdate());
    }

    // Update is called once per frame
    void Update()
    {



        
    }
}
