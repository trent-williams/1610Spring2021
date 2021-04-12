using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class Trigger2DBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Collider2D>()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
