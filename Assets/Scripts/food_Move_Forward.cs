using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_Move_Forward : MonoBehaviour

{
    //Create and/or Assign Variables
    public float throwSpeed = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * throwSpeed);
    }
}
