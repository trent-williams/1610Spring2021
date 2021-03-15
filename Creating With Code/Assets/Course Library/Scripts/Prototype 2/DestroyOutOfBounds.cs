using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundry = 40f;
    private float lowerBoundry = -20f;
  
    void Update()
    {
        if (transform.position.z > topBoundry)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBoundry)
        {
            Destroy(gameObject);
        }
    }
}
