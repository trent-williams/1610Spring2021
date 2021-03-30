using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;

    private void Update()
    {
        float horzontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horzontalInput * rotationSpeed * Time.deltaTime);
    }
}
