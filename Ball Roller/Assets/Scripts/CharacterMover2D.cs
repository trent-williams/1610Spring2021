using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMover2D : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 2f;
    public IntData jumpCountMax;
    
    private Rigidbody2D rigidbodyObj;
    private Vector2 direction;
    private int jumpCount;


    private void Awake()
    {
        rigidbodyObj = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter(Collision other)
    {
        jumpCount = 0;
    }

    private void Update()
    {
        direction.x = speed * Input.GetAxis("Horizontal");
        rigidbodyObj.AddForce(direction, ForceMode2D.Force);

        if (!Input.GetButtonDown("Jump") || jumpCount >= jumpCountMax.value) return;
        direction.y = jumpForce;
        rigidbodyObj.AddForce(direction, ForceMode2D.Impulse);
        jumpCount++;
    }
}