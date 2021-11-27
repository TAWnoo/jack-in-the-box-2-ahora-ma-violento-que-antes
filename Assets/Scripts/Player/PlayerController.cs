using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public CharacterController controller;
    private Vector3 direction;
    public float speed;
    public float jumpForce;
    public float gravity;
    float hInput;
    public Transform groundCheck;
    bool isGrounded;
    public LayerMask groundLayer;
    public bool canSecondJump = true;
    public Animator anim;
    public SpriteRenderer sr;

    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        direction.x = hInput * speed;
        anim.SetFloat("Speed", Mathf.Abs(hInput));
        controller.Move(direction * Time.deltaTime);
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.2f, groundLayer);
        if (isGrounded)
        {
            anim.SetBool("Lands", true);
            canSecondJump = true;
            if (Input.GetButtonDown("Jump"))
            {
                anim.SetBool("Jumps", true);
                direction.y = jumpForce;
            }
        }
        else
        {
            anim.SetBool("Lands", false);
            anim.SetBool("Jumps", false);
            direction.y += gravity * Time.deltaTime;
            if (canSecondJump & Input.GetButtonDown("Jump"))
            {
               direction.y = jumpForce;
               anim.SetBool("Jumps", true);
               canSecondJump = false;
            }
        }

        if (!sr.flipX && hInput < 0)
        {
            sr.flipX = true;
        }
        else if (sr.flipX && hInput > 0)
        {
            sr.flipX = false;
        }
        
    }

    
}
