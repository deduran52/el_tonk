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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tank"))
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
