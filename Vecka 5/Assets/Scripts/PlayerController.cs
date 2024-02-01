using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 20f;
    public GameObject projectile;
    private float fireCooldown = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireCooldown -= Time.deltaTime;
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput,0,0) * Time.deltaTime * speed);
        
        // If left-mouse button is pressed down...
        if (Input.GetMouseButtonDown(0) && fireCooldown <= 0)
        {
            // ...then spawn a projectile at the player's position.
         Instantiate(projectile, transform.position + new Vector3(0,1f,0), projectile.transform.rotation);  
            // Reset the fire cooldown.
            fireCooldown = 0.5f;
        }
        
    }
}
