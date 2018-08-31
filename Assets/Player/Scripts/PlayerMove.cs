using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    // Use this for initialization

    public float direction;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("a"))
        {
            Vector3 rotation = new Vector3(0.0f, 0.0f, -direction);
            transform.Rotate(rotation * Time.deltaTime);
        }
        else if (Input.GetKey("d"))
        {
            Vector3 rotation = new Vector3(0.0f, 0.0f, direction);
            transform.Rotate(rotation * Time.deltaTime);
        }
    }
}
