using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteakMovement : MonoBehaviour
{
    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += (new Vector3(0,0,1) * Time.deltaTime * speed);
        
        if(transform.position.z > 22){
            Destroy(gameObject);
        }

        
    }

     private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Animal"){
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

    void oncollisionenter(Collision other){
        if(other.gameObject.tag == "Animal"){
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
