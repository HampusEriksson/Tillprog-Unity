using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnimator;
    private float jumpForce = 1200.0f;
    private float gravityModifier = 2.0f;
    private bool isGrounded = true;
    public bool gameOver = false;
    public ParticleSystem dirtParticle;
    public ParticleSystem explosion;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAnimator.SetFloat("Speed_f", 1f);

        Physics.gravity *= gravityModifier;
        dirtParticle.Play();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            playerAnimator.SetFloat("Speed_f", 0f);
            playerAnimator.SetBool("Jump_trig", true);
            dirtParticle.Stop();
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Obstacle")){
            Debug.Log("Game Over");
            playerAnimator.SetBool("Death_b", true);
            gameOver = true;
            explosion.Play();
            dirtParticle.Stop();
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            playerAnimator.SetFloat("Speed_f", 1f);
            dirtParticle.Play();
        }
        
    }
}
