using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float jumpForce = 5f;
    public float walkSpeed = 100f;
    public float sprintSpeed = 150;
    private float moveSpeed;
    private bool canJump = true;
    public float rayLength = 1.2f;
   
    public LayerMask Mask;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        Vector3 newVelocity = rb.velocity;
        if(Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveSpeed = sprintSpeed;
            }
            else
            {
                moveSpeed = walkSpeed;
            }
            newVelocity.z = moveSpeed * Time.deltaTime; 

        }
        else if (Input.GetKey(KeyCode.S))
        {
            newVelocity.z = -moveSpeed * Time.deltaTime;
        }
        else
        {
            newVelocity.z = 0;
        }
        if (Input.GetKey(KeyCode.D))
        {
            newVelocity.x = moveSpeed * Time.deltaTime;
        }
       else if (Input.GetKey(KeyCode.A))
        {
            newVelocity.x = -moveSpeed * Time.deltaTime;
        }
        else
        {
            newVelocity.x = 0;
        }
        CheckGrounded();
        if(Input.GetKeyDown(KeyCode.Space)&& canJump)
        {
            rb.AddForce(0, jumpForce, 0);
        }
        
        
        rb.velocity = newVelocity;

    }

    private void CheckGrounded()
    {
      canJump = Physics.Raycast(transform.position, -Vector3.up, rayLength,  Mask );
    }


}
