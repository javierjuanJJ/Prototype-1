using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    //[SerializeField] private float speed = 20;
    [SerializeField] private float horsePower;
    [SerializeField] private float turnSpeed = 2;
    private float horizontalInput;
    private float forwardInput;

    private Rigidbody playerRb;

    [SerializeField] private Camera mainCamera, hoodCamera;

    [SerializeField] private KeyCode switchKey;

    [SerializeField] private string inputID;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Move the vehicle forward
        // transform.Translate(0,0,3);
        // transform.Translate(Vector3.forward);
        // transform.Translate(Vector3.forward * Time.deltaTime * 20);

        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        
        playerRb.AddRelativeForce(Vector3.forward * (horsePower * forwardInput));
        
        //transform.Translate(Vector3.forward * (Time.deltaTime * speed * forwardInput));
        //transform.Translate(Vector3.right * (Time.deltaTime * turnSpeed * horizontalInput));
        transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
        
    }
}
