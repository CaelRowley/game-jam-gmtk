using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour {
    public float lifespan;

    // Destroys gameObject after lifespan is up
    void Start() {
        Destroy(gameObject, lifespan);
    }
}
