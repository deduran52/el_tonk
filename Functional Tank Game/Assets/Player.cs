using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
    //This script represents a connected player , who might "own" other objects in the game
{
    // Start is called before the first frame update
    void Start()
    {
        //FOR NOW we are going to spwan a players tank as soon as they connect
        //AND when they die they will respawn after 3 secconds
        spawnTank();
    }//end start
    public GameObject TankPrefab;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnTank()
    {
        //this gets called by the game manager when the new round starts 
        //and a player needs a tank

        //TODO: This player may have a favorite color so consider customizing their tank
        Instantiate(TankPrefab);

    }//end spawnTank
}
