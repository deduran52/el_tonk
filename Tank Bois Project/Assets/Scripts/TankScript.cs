using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    
    float speed = 5.0f;
    public float projectilespeed;
    public Rigidbody2D projectile;
    public GameObject emit;
    public GameObject TurrentRotation;


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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            TurrentRotation.transform.Rotate(0, 0, 1);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            TurrentRotation.transform.Rotate(0, 0, -1);
        }
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Rigidbody2D iP = Instantiate(projectile, emit.transform.position, emit.transform.rotation) as Rigidbody2D;
        //    iP.AddForce(right);
        //}

        /*
         if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
          transform.position += Vector3.down * speed * Time.deltaTime;
        }
        */
    }
}
