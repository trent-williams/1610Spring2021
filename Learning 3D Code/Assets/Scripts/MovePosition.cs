using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 3f;

    private Vector3 direction;
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
        direction.Set(horizontalInput * speed, 0, 0); // <<Best way to set Vector3
        transform.Translate(direction * Time.deltaTime);
    }
}
