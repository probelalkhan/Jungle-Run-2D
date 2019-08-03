using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed; 
    public float jump; 
    
    public LayerMask ground; 
    
    private Rigidbody2D rigidBody; 
    private Collider2D playerCollider; 
    private Animator animator; 

    void Start()
    {
       rigidBody = GetComponent<Rigidbody2D>(); 
       playerCollider = GetComponent<Collider2D>(); 
       animator = GetComponent<Animator>();
    }


    void Update()
    {
        rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y);

        bool grounded = Physics2D.IsTouchingLayers(playerCollider, ground);

        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){
            if(grounded)
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jump);
        }

        animator.SetBool("Grounded", grounded);

    }
}
