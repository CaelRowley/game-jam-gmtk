using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    // Use this for initialization

    public float direction;

    public string input1;
    public string input2;

    void Start () {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(input1))
        {
            Vector3 rotation = new Vector3(0.0f, 0.0f, -direction);
            transform.Rotate(rotation * Time.deltaTime);
        }
        else if (Input.GetKey(input2))
        {
            Vector3 rotation = new Vector3(0.0f, 0.0f, direction);
            transform.Rotate(rotation * Time.deltaTime);
        }
    }
}
