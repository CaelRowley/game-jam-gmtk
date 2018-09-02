using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public GameObject trapToSpawn;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collison)
    {
        Debug.Log("Winner!!!!");
        Instantiate(trapToSpawn);
    }
}
