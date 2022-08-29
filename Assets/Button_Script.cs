using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Script : MonoBehaviour
{
    public GameObject Joystick;

    bool a1;
    bool a2;
    bool a3;
    bool a4;
    bool a5;

    public bool isButtonPressed;
    Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mousePos = Input.mousePosition;
        if ((Input.GetButton("Fire1")) && (mousePos.x > 150 && mousePos.x < 900 && mousePos.y > 150 && mousePos.y < 900))
        {
         //   Debug.Log("Button was pressed!");
      ///////      Joystick.transform.position = new Vector3(mousePos.x - 124, mousePos.y - 124, mousePos.z);//25-40
        }
        #region Debug Code
        /*
        if (Input.GetButtonDown("Fire1"))
        {
            a1 = true;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            a1 = false;
        }
        if (mousePos.x > 150)
        {
            a2 = true;
        }
        else
        {
            a2 = false;
        }
        if (mousePos.x < 900)
        {
            a3 = true;
        }
        else
        {
            a3 = false;
        }
        if (mousePos.y > 0)
        {
            a4 = true;
        }
        else
        {
            a4 = false;
        }
        if (mousePos.y < 750)
        {
            a5 = true;
        }
        else
        {
            a5 = false;
        }
        Debug.Log(a1 + " " + a2 + " " + a3 + " " + a4 + " " + a5 + " " + mousePos.x + " " + mousePos.y);
        */
        #endregion
    }

    public void ButtonPress()
    {
        Debug.Log("Pressed");
        Joystick.transform.position = new Vector3(mousePos.x - 124, mousePos.y - 124, mousePos.z);//25-40
        ///    isButtonPressed = true;
    }
}
