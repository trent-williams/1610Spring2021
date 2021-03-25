using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds3 : MonoBehaviour
{
    public float bottomBoundry = -5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomBoundry)
        {
            Destroy(gameObject);
        }
    }
}
