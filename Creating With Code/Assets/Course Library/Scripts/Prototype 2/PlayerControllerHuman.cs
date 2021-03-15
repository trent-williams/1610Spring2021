using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerHuman : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 10f;
    public GameObject projectivePrefab;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        //Movement
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (horizontalInput * speed * Time.deltaTime));
        
        //Shooting stuff
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch the gosh darn bone
            Instantiate(projectivePrefab, transform.position, projectivePrefab.transform.rotation);
        }
    }
}
