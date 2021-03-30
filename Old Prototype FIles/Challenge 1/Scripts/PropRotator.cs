using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropRotator : MonoBehaviour
{
    public float propSpeed = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * propSpeed * Time.deltaTime);
    }
}
