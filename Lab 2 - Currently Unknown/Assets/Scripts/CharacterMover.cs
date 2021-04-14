using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    public float speed = 3f, gravity = -8f, jumpForce = 10f;
    public int jumpCountMax = 2;

    private CharacterController controller;   
    private Vector3 movement;
    private float yDirection;
    private int jumpCount;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        movement.Set(0, yDirection,speed*Input.GetAxis("Vertical"));

        yDirection += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yDirection = -1f;
            jumpCount = 0;
        }
        
        //Double jump constraint
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            yDirection = jumpForce;
            jumpCount++;
        }

        //transform.Rotate(rotation);
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}