using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class UserInput : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 2f;
    
    private Rigidbody2D rigidbodyObj;
    private Vector2 direction;


    private void Start()
    {
        rigidbodyObj = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direction.x = speed * Input.GetAxis("Horizontal");
        rigidbodyObj.AddForce(direction, ForceMode2D.Force);

        if (Input.GetButtonDown("Jump"))
        {
            direction.y = jumpForce;
            rigidbodyObj.AddForce(direction, ForceMode2D.Force);
        }
        
    }
}