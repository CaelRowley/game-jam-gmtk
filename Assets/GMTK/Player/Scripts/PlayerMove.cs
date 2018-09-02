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
    private bool jumping = false;
    private int jumpCount = 0;
    private SpriteRenderer spriteRenderer;

    void Start () {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
	
	void Update () {

        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis(input1); 

        transform.position += moveDir * speed * Time.deltaTime;
        Jump();
        HandleSprite(moveDir);

    }

    void HandleSprite(Vector3 moveDir) {
        bool flipSprite = (spriteRenderer.flipX ? (moveDir.x > 0.00f) : (moveDir.x < 0.00f));
        if (flipSprite) {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
    }

    void Jump() {
        if (jumpCount < 2 || !jumping) {
            if (Input.GetKeyDown(action1))
            {
                rb.velocity = new Vector3(0, jumpSpeed, 0);
                jumpCount++;
                jumping = true;
            }
            else if (Input.GetKeyUp(action1))
            {
                if (rb.velocity.y > 0)
                {
                    rb.velocity = rb.velocity * .05f;
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collison)
    {
        //Debug.Log("collision");
        jumping = false;
    }
}
