using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    GvrControllerButton button;
    public GameObject Debugger;
    enum Context {Firing = 0, Menu = 1, Unarmed = 3}
    Context context = Context.Firing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") || Input.touches.Length > 0)
           
        {

            switch (context) {
                case Context.Firing:

                    GetComponent<CannonFunction>().Fire();
                    Debugger.GetComponent<DebugInfo>().BulletsActive++;
                    Debugger.GetComponent<DebugInfo>().BulletsFired++;

                    break;
                case Context.Menu:
                    break;
                case Context.Unarmed:
                    break;

            }
            
        }
    }

    public void OnCardboardTrigger()
    {
        GetComponent<CannonFunction>().Fire();
    }

   
}
