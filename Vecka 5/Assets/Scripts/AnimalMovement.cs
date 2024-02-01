using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (new Vector3(0,0,-1) * Time.deltaTime * speed);

        if (transform.position.z < -5)
        {
            Destroy(gameObject);
        }
    }
}
