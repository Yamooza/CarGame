using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [Header("Car Settings")]
    public float accelerationFactor = 30.0f;
    public float turnFactor = 3.5f;

    //Local variables
    float accelerationInput = 0;
    float steeringInput = 0;

    float rotationAngle = 0;


    //components
    Rigidbody2D carRigibody2D;

    //Awake is called when the script instance is being loaded
    private void Awake()
    {
        carRigibody2D = GetComponent<Rigidbody2D>();
    }
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        ApplyEngineForce();

        ApplySteering();
    }
    void ApplyEngineForce()
    {
        //Create force for the engine
        Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

        //apply force to push the car
        carRigibody2D.AddForce(engineForceVector, ForceMode2D.Force);
    }
    void ApplySteering()
    {
        //update the rotation angle baseed on input
        rotationAngle -= steeringInput * turnFactor;

        //apply steering by rotating the car object
        carRigibody2D.MoveRotation(rotationAngle);
    }
    public void SetInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }


}
