using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float pressDelay = 2;

    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && pressDelay < 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            pressDelay = 2; //Set Press Delay to 2 seconds
        }

        if (pressDelay > 0) {
            pressDelay -= Time.deltaTime; //Count down 2 seconds using Delta Time
        }
    }
}
