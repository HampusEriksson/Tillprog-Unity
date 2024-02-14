using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float hp;
    public float damage;
    public float speed;
    public float sprintSpeed;
    public float turnTimer = 1f;
    void Start()
    {

    }

    void Update()
    {
        Move();

    }

    void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        turnTimer -= Time.deltaTime;
        if(turnTimer < 0f)
        {
            turnTimer = 1f;
            transform.Rotate(Vector3.up, Random.Range(-120, 120));
        }

        if (Mathf.Abs(transform.position.x)>24 || Mathf.Abs(transform.position.z) > 24)
        {
            transform.LookAt(Vector3.zero);
            transform.Translate(Vector3.forward * sprintSpeed * Time.deltaTime);
        }
       

    }

    public void TakeDamage(float takenDamage)
    {
        hp -= takenDamage;
        Debug.Log("New hp is" +  hp);
        if (hp <= 0f)
        {
            Destroy(gameObject);
        }

    }
}
