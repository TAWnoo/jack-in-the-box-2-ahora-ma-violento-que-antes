using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_mov : MonoBehaviour
{
    public float speed;
    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public bool canSecondJump = true;
    public float jumpForce;
    public float gravity;
    private Vector3 direction;

    void Start()
    {
        speed = 7;
    }


    void Update()
    {
        if (17 > speed)
        {
            speed += Time.deltaTime;
        }
        else
        {
            speed = 17;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);

        isGrounded = Physics.CheckSphere(groundCheck.position, 0.2f, groundLayer);
        if (isGrounded)
        {
            
            canSecondJump = true;
            if (Input.GetButtonDown("Jump"))
            {
                
                direction.y = jumpForce;
            }
        }
        else
        {
            
            direction.y += gravity * Time.deltaTime;
            if (canSecondJump & Input.GetButtonDown("Jump"))
            {
                direction.y = jumpForce;
                
                canSecondJump = false;
            }

        }


    }
}
