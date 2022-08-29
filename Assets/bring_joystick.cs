using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bring_joystick : MonoBehaviour
{
    public GameObject back, joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BringJoystick()
    {
        back.gameObject.SetActive(true);
        joystick.gameObject.SetActive(true);
    }
}
