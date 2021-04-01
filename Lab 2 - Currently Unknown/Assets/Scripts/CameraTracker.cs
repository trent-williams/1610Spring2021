using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(-7, 5, 0);
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
