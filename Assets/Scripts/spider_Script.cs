using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spider_Script : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Rigidbody rb;
    bool isAttacking;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isAttacking)
        {
            float jumpingSpeed = 5000;
            float xSpeed = 0;
            float ySpeed = 0;

            if (transform.position.x < player.transform.position.x-5)
            {
                xSpeed = jumpingSpeed * 0.5f;
            }
            else if (transform.position.x > player.transform.position.x+5)
            {
                xSpeed = -jumpingSpeed * 0.5f;
            }
            if (transform.position.x > player.transform.position.x - 5 && transform.position.x <  player.transform.position.x + 5)
            {
                Debug.Log("Same X");
                rb.constraints = RigidbodyConstraints.FreezePositionX;
                xSpeed = 0;
            }

            if (transform.position.y < player.transform.position.y-5)
            {
                ySpeed = jumpingSpeed * 0.5f;
            }
            else if (transform.position.y > player.transform.position.y+5)
            {
                ySpeed = -jumpingSpeed * 0.5f;
            }
            if (transform.position.y >  player.transform.position.y - 5 && transform.position.y <  player.transform.position.y + 5)
            {
                Debug.Log("Same Y");
                rb.constraints = RigidbodyConstraints.FreezePositionY;
                ySpeed = 0;
            }

            rb.AddForce(new Vector3 (xSpeed, ySpeed, -jumpingSpeed) * Time.deltaTime, ForceMode.Impulse);
        }
        
    }

    //Appearin from of the kid for a final jumping strike
    public void Teleport()
    {
        transform.position = new Vector3(2, -42, 250 + player.transform.position.z);
        isAttacking = true;
    }
}
