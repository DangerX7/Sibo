using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class temporar_move_script : MonoBehaviour
{
    private Rigidbody rb;
    private float dirX, dirY, moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
    //    dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
    //    dirY = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed;
    }

    private void FixedUpdate()
    {
   //     rb.velocity = new Vector2(dirX, dirY);
    }
}
