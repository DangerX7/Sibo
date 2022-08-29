using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick_Script_dan : MonoBehaviour
{
    public GameObject Player;
    Vector3 startPos, currentPos, mousePos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Cylinder")
                {
                    currentPos = transform.position;
                    Debug.Log("x=" + transform.position.x + " y=" + transform.position.y);
                 ///   transform.position = new Vector3(mousePos.x - 124, mousePos.y - 124, mousePos.z);//25-40
                 ////   Player.transform.position = new Vector3(0 + ((currentPos.x-startPos.x)/10), -12.8f + ((currentPos.y-startPos.y)/10), 86.7f);
                }
            }
        }
    }
}
