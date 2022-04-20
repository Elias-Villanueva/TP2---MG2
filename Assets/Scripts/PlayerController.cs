using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 gravity;
    public Vector3 jumpSpeed;

    bool isGrounded;
    bool dobleJump;

    Rigidbody rb;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = gravity;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             if (isGrounded)
            {
                rb.velocity = jumpSpeed;
                isGrounded = false;

                
            }else if (dobleJump)
                {
                    rb.velocity = Vector3.zero;
                    rb.velocity = jumpSpeed;
                    dobleJump = false;
                }
        
        }

        if (isGrounded)
        {
            dobleJump = true;
        }
        

        
    }

    private void OnCollisionEnter(Collision collision) 
    {
        isGrounded = true;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "obstacle")
        {
            gameManager.GameOver();
        }
    }

    
}
