using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private  Vector3 offset;
    private Vector3 rotationOffset = new Vector3(30.0f, 90.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3 (-2.6f,2.0f,0.0f);

        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
        
    }
}
