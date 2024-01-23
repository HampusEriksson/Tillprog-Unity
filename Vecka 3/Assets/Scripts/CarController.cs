using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 30.0f;
    private float forwardInput;
    private float turnInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    
          
          transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * turnInput);
    }
}
