using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enable_dissable_joystick : MonoBehaviour
{
    public GameObject Joystick, Back;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("p");
            Touch touch = Input.GetTouch(0);

            // Update the Text on the screen depending on current position of the touch each frame
            Debug.Log("Touch Position : " + touch.position);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Input.mousePosition;
            {
         //       Debug.Log(mousePos.x);
         //       Debug.Log(mousePos.y);
            }

            Joystick.gameObject.SetActive(true);
            Joystick.transform.position = new Vector3(mousePos.x - 124, mousePos.y - 124, mousePos.z);
            Back.gameObject.SetActive(true);
            Back.transform.position = new Vector3(mousePos.x - 146, mousePos.y - 146, mousePos.z);

        }

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "MoveJoystick")
                {
                    Debug.Log("hit");
                }
            }
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.green, 100f); // only draws once. Re-clicking does nothing
        }

        if (Input.GetButtonUp("Fire1"))
        {
        //    Joystick.gameObject.SetActive(false);
        //    Back.gameObject.SetActive(false);
        }


    }
}
