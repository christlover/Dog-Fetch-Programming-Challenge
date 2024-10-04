using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Off_Screen : MonoBehaviour {
    private float topBound = 30.0f;
    private float lowerBound = -20;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (transform.position.z > topBound) {
            Destroy(gameObject); //Destroy Food When Past The Map
        } else if (transform.position.z < lowerBound) {
            Destroy(gameObject); //Destroy Object if out of bounds
            Debug.Log("Game Over"); //Display Gsme Over on Console if an Animal Gets Through
        }
    }
}
