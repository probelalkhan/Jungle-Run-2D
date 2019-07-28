using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed; 
    private Rigidbody2D rigidBody; 

    void Start()
    {
       rigidBody = GetComponent<Rigidbody2D>(); 
    }


    void Update()
    {
        rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y);
    }
}
