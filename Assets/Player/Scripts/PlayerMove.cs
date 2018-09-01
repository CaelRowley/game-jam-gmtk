using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    // Use this for initialization

    public float direction;

    public string input1;
    public string input2;

    public float speed;

    void Start () {
        //gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis(input1); 
        moveDir.z = Input.GetAxis(input2);
        Debug.Log(moveDir);

        transform.position += moveDir * speed * Time.deltaTime;
        //if (Input.GetKey(input1))
        //{
        //    //float step = 10 * Time.deltaTime;
        //    //Vector3 position = transform.position;
        //    //position.y = Mathf.Lerp(transform.position.y, mouse.transform.position.y, step);
        //    //position.x = Mathf.Lerp(transform.position.x, mouse.transform.position.x, step);

        //    //transform.position = position;
        //}
        //else if (Input.GetKey(input2))
        //{
        //    Vector3 rotation = new Vector3(0.0f, 0.0f, direction);
        //    transform.Rotate(rotation * Time.deltaTime);
        //}
    }
}
