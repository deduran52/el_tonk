using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : MonoBehaviour {
    // This script represents a connected player, who might "own" other objects in the game
    // Start is called before the first frame update

    public GameObject TankPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTank()
    {
        Instantiate(TankPrefab);
    }
}
