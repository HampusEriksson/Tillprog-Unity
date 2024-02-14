using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerController : Animal
{

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Deer") || other.gameObject.CompareTag("Chicken"))
        {
            other.gameObject.GetComponent<Animal>().TakeDamage(damage);
        }
    }

}