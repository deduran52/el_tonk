using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    public float delay;

    private void Update()
    {
        Destroy(gameObject, delay);
    }

    private void OnTriggerEnter(Collider2D other)
    {
        if (other.gameObject.CompareTag("Tank"))
        {
            Destroy(other.gameObject);
        }

        else if(other.gameObject.CompareTag("Terrain"))
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}

