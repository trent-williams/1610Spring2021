using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;
    
    void Start()
    {
        
    }
    
    void Update()
    {
     // Move the vehicle forward   
     horizontalInput = Input.GetAxis("Horizontal");
     forwardInput = Input.GetAxis("Vertical");
     
     transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
     //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
     transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
