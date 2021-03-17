using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletBehavior : MonoBehaviour
{
    private Rigidbody bulletRB;
    private Vector3 forces;
    
    public float bulletForce = 1000f;

    private void Start()
    {
        bulletRB = GetComponent<Rigidbody>();
        forces.Set(bulletForce,0,0);
        bulletRB.AddRelativeForce(forces);
    }
}
