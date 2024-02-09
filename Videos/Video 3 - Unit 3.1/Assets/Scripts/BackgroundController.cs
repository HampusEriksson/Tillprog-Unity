using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private Vector3 startPos;
    private float speed = 4.0f;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.gameOver == false)
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }


        if (transform.position.x <= -6)
        {
            transform.position = startPos;
        }

    }

        
}
