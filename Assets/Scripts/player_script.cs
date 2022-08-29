using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class player_script : MonoBehaviour
{
    private spider_Script spiderScript;
    public GameObject spider, joyField;
    private Vector3 Movement;

    public Rigidbody joyRB;
    private Rigidbody rb;
    [SerializeField] float dirX, dirY, moveSpeed, forwardSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spiderScript = spider.GetComponent<spider_Script>();
        moveSpeed = 70f;
        forwardSpeed = 200f;
    }

    private void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        dirY = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     //   Debug.Log(3.14f * (Mathf.Pow(5, 2)));
     //   Debug.Log(dirX + " X " + dirY);
        Movement = new Vector3(dirX, dirY, forwardSpeed);
        //    rb.useGravity = false;

        //Automatically move on Z axis
     /////////////////////   rb.velocity = Movement;
      /////////////////////////////  joyRB.velocity = Movement;

        /*
      //  rb.AddForce(Movement * Time.deltaTime, ForceMode.Acceleration);

        //Move with on X and Y Axis with inputs
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
     //       rb.AddForce(Vector3.up * moveSpeedUpLeftRight * Time.deltaTime, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
      //      rb.AddForce(Vector3.down * moveSpeedDown * Time.deltaTime, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
      //      rb.AddForce(Vector3.left * moveSpeedUpLeftRight * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
     //       rb.AddForce(Vector3.right * moveSpeedUpLeftRight * Time.deltaTime);
        }
        */

    }

    private void OnCollisionEnter(Collision collision)
    {//Freeze player if it touches a spider web
        if (collision.gameObject.tag.Equals("web"))
        {
            FreezePlayer();
            spiderScript.Teleport();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("spider"))
        {
            RestartGame();
        }
    }


    void FreezePlayer()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }

    void UnfreezePlayer()
    {
        rb.constraints = RigidbodyConstraints.None;
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /*
        if (Input.anyKey)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
        else
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
     */
}
