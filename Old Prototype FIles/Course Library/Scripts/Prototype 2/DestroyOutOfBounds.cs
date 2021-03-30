using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundry = 40f;
    private float lowerBoundry = -20f;
  
    void Update()
    {
        //Get rid of stuff that leaves the screen
        if (transform.position.z > topBoundry)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBoundry)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
