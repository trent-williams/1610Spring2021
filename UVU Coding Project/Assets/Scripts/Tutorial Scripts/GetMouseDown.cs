using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMouseDown : MonoBehaviour
{
    private void OnMouseDown()
    {
        rigidbody.AddForce(-transform.forward * 500f);
        Rigidbody.useGravity = true
    }
}
