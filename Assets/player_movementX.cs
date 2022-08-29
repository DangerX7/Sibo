using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class player_movementX : MonoBehaviour
{
    public GameObject player, handle;
    Vector3 StartPos, Difference, Target, Dirrection, PosCheck;
    public Rigidbody PlayerRB;
    int dirX, dirY;
    private void Start()
    {
        //    Difference = new Vector3(-540, -383.75f, 86.7f);
        StartPos = new Vector3(transform.position.x, transform.position.y, 0);
        Difference = new Vector3(-54, -37.125f, 0);
    }

    private void FixedUpdate()
    {//(0, -12.8f, 86.7f)
        Target = new Vector3(handle.transform.position.x / 10, handle.transform.position.y / 10, 0)+ Difference;
        PosCheck = handle.transform.position;

        if (Input.GetMouseButton(0) && PosCheck != handle.transform.position)
        {
            Dirrection = (Target - transform.position).normalized;
            PlayerRB.AddForce(Dirrection * 100000 * Time.deltaTime);
        }
        else
        {
            //    Dirrection = (StartPos - transform.position).normalized;
        }
    }
}
