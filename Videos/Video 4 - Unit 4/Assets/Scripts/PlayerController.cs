using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 3.0f;
    private Rigidbody playerRb;
    private GameObject midPoint;
    public bool hasPowerup;
    private float powerupStrength = 15.0f;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        midPoint = GameObject.Find("Middle Point");
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        playerRb.AddForce(midPoint.transform.forward * speed * forwardInput);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            // Get the enemy rigidbody
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            // Get the direction from the player to the enemy
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position).normalized;
            // Add force away from the player
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }


}
