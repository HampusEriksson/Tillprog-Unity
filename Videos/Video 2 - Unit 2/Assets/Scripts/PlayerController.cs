using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private float speed = 30f;
    private float horizontalInput;
    [SerializeField] GameObject pizza;
    private float fireCooldown = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireCooldown -= Time.deltaTime;
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        float x = Mathf.Clamp(transform.position.x, -15.5f, 15.5f);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space) && fireCooldown <= 0f)
        {
            Instantiate(pizza, transform.position + new Vector3(0f, 1f, 0f), pizza.transform.rotation);
            fireCooldown = 0.5f;
        }
        
    }

    
}
