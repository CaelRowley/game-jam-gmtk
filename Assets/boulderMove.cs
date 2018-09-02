using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulderMove : MonoBehaviour {
    public float moveSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(moveSpeed, 0, 0);
    }
}
