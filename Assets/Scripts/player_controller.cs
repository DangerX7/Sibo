using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_controller : MonoBehaviour
{
    private CharacterController controller;
    private PlayerInput playerInput;
    public Vector2 movementInput;
    private Rigidbody rb;
    private float speed;

    Vector3 movement;
    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
        speed = 2f;
    }

    void Update()
    {
        movement = new Vector3(speed * movementInput.x, speed * movementInput.y, 0);
     //////////////////////////////////////////////////////////////////////////////////////////////   transform.position += movement;
        //   rb.AddForce(movement * speed * Time.deltaTime);
     //   Debug.Log(transform.position.x + " " + transform.position.y);
    }

    public void Move(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }
}