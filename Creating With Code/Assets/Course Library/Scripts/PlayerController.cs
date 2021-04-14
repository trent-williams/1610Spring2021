using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horsePower = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    
    [SerializeField] private GameObject centerOfMass;
    [SerializeField] private TextMeshPro speedometerText, rpmText;
    [SerializeField] private float speed, rpm;

    [SerializeField] private List<WheelCollider> allWheels;
    [SerializeField] private int wheelsOnGround;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    void Update()
    {
     // Move the vehicle forward   
     horizontalInput = Input.GetAxis("Horizontal");
     verticalInput = Input.GetAxis("Vertical");

     if (IsOnGround())
         {
            playerRb.AddRelativeForce(Vector3.forward * (verticalInput * horsePower));
            //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

            //Spedometers and RPM Gauges
            speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
            speedometerText.SetText("Speed: " + speed + "mph");
            rpm = Mathf.Round((speed % 30) * 40);
            rpmText.SetText("RPM: " + rpm);
        }
     }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
