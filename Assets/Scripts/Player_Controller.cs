using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    //Create and/or Assign Variables
    public float horizontalInput; 
    public float moveSpeed = 30.0f; //Player Move Speed
    
    public float xRange_left = -19; //X Boundary Left
    public float xRange_right = 19; //X Boundary Right

    public GameObject projectilePrefab; //Create Prefab for Food



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Assign Left and Right Buttons to Move Character
        horizontalInput = Input.GetAxis("Horizontal");

        //Move Character
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * moveSpeed);

        //Stop Character if Going Out of Bounds
        if (transform.position.x < -19) { 
            //Left Boundary
            transform.position = new Vector3(xRange_left, transform.position.y, transform.position.z);
        } else if (transform.position.x > 19) { 
            //Right Boundary
            transform.position = new Vector3(xRange_right, transform.position.y, transform.position.z);
        }

        //Check if Space is Pressed
        if (Input.GetKeyDown(KeyCode.Space)) {
            //Throw Food
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
