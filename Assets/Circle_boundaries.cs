using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_boundaries : MonoBehaviour
{
    Vector3 centerPosition = Vector3.zero;
    float distance = 100;
    Vector3 newLocation = Vector3.zero;

    public Button_Script button_Script;

    // Start is called before the first frame update
    void Start()
    {
        centerPosition = new Vector3(transform.position.x + 164, transform.position.y - 164, transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        newLocation = new Vector3 (transform.position.x + 164, transform.position.y + 164, transform.position.z);
        Vector3 mousePos = Input.mousePosition;
        distance = Vector3.Distance(mousePos, centerPosition);

          Debug.Log(centerPosition + " # " + distance + " # " + mousePos);//300


        if (distance > 300) 
        {

        }
        else
        {

        }

     //   Debug.Log(button_Script.isButtonPressed + " # " + (Input.GetButton("Fire1")));//300


        if (button_Script.isButtonPressed && (Input.GetButton("Fire1")))
        {
            transform.position = new Vector3(mousePos.x - 124, mousePos.y - 124, mousePos.z);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (distance < 300)
            {
                button_Script.isButtonPressed = true;
                Debug.Log("YES" + centerPosition + " # " + distance + " # " + newLocation);
            }
            else
            {
                button_Script.isButtonPressed = false;
                Debug.Log("NO" + centerPosition + " # " + distance + " # " + newLocation);
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            button_Script.isButtonPressed = false;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2.2f);

    }
}
