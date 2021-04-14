using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 movement;
    [SerializeField] float speed = 3f, gravity = -8f;
    
    void FixedUpdate()
    {
        movement.y = gravity;
        movement.x = speed * Input.GetAxis("Horizontal");
        controller.Move(movement * Time.deltaTime);
    }
}
