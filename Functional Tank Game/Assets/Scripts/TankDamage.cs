﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankDamage : MonoBehaviour
{

    public float startHealth = 100;
    private float currentHealth;
    public bool isGrounded = false;
    public float impactDelay;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Bullet"))
        {
            currentHealth = currentHealth - 10;
            if (currentHealth <= 0)
                Destroy(gameObject, impactDelay);

        }
    }
}
