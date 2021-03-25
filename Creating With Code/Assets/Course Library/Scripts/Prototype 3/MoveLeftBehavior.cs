using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftBehavior : MonoBehaviour
{
    public float speed = 5f;

    private PlayerController3 playerControllerScript;
    
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController3>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * speed));
        }
        
    }
}
