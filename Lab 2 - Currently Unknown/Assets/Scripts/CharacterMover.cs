using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    public float speed = 3f, gravity = -8f, jumpForce = 10f, rearBoundry = 7f;
    public int jumpCountMax = 2;
    

    private CharacterController controller;   
    private Vector3 movement, rotation;
    private float yDirection;
    private int jumpCount;
    private Animator playerAnim;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        playerAnim = GetComponent<Animator>();
    }

    void Update()
    {
        movement.Set(0, yDirection,speed*Input.GetAxis("Vertical"));

        yDirection += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yDirection = -1f;
            jumpCount = 0;
        }
        
        //Double jump constraint
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            yDirection = jumpForce;
            jumpCount++;
        }

        rotation.y = Input.GetAxis("Horizontal");
        //transform.Rotate(rotation);
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}