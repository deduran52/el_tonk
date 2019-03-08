using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    float speed = 5.0f;
    public GameObject TurretRotation;
    //public RigidBody2D projectile;
    //public GameObject Emitter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*
         * Next if statements are for tank sprite movement
         * 
         */
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        //
        // This code should make the Turret Rotate
        //
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            TurretRotation.transform.Rotate(0, 0, 2);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            TurretRotation.transform.Rotate(0, 0, -2);
        }
        
        //
        // The Below code is commented out due to the fact that it adds up and down movement to the tank,
        // which is not needed for this game.
        //
        
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        /*
        if (Input.GetKey(KeyCode.DownArrow))
        {
          transform.position += Vector3.down * speed * Time.deltaTime;
        }
        */

    }
}
