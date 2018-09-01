using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    // Use this for initialization

    public float direction;

    public string input1;
    public string input2;

    public string action1;

    public float speed;
    public float jumpSpeed;

    private Rigidbody2D rb;

    void Start () {
        //gameObject.GetComponent<Renderer>().material.color = Color.red;

        rb = gameObject.GetComponent<Rigidbody2D>();
    }
	
	void Update () {

        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis(input1); 
        moveDir.y = Input.GetAxis("Jump");

        transform.position += moveDir * speed * Time.deltaTime;
        Jump();
    }

    void Jump() {
        if (Input.GetKeyDown(action1))
        {
            rb.velocity = new Vector3(0, jumpSpeed, 0);
            Debug.Log("Jump");
        }
        else if (Input.GetKeyUp(action1))
        {
            if (rb.velocity.y > 0) {
                rb.velocity = rb.velocity * .05f;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collison)
    {
        Debug.Log("collision");
    }
}
