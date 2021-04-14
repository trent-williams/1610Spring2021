using System;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AddForcesBehavior : MonoBehaviour
{
    private Rigidbody rigidbodyObj;
    private Vector3 forces;
    
    public float bulletForce = 1000f;
    
    public enum ForceDirections
    {
        X,Y,Z
    }

    public ForceDirections forceDirection;
    
    private void Awake()
    {
        rigidbodyObj = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rigidbodyObj.WakeUp();
        switch (forceDirection)
        {
            case ForceDirections.X:
                forces.Set(bulletForce,0,0);
                break;
            case ForceDirections.Y:
                forces.Set(0,bulletForce,0);
                break;
            case ForceDirections.Z:
                forces.Set(0,0,bulletForce);
                break;
            default:
                forces.Set(bulletForce,0,0);
                break;
        }
        rigidbodyObj.AddRelativeForce(forces);
    }

    private void OnDisable()
    {
        rigidbodyObj.Sleep();
    }
}
