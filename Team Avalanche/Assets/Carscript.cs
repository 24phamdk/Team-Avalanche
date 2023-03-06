using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carscript : MonoBehaviour
{
    private float speed = 50.0f;   
    private float turnSpeed = 45.0f;
    private float bSpeed = 80.0f;

    private float horizontalInput;
    private float forwardInput;

    public float boostTrue = 7;
    public float refreshTime = 5;

    void Update()
    {
        horizontalInput=Input.GetAxis("Horizontal");
        forwardInput=Input.GetAxis("Vertical");
        
        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
        // Boosts car based on "shift' as input
        if (Input.GetKey (KeyCode.LeftShift))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * bSpeed * forwardInput);
        }
        
        
            
            
        
      
        
         
        

    }
    
}