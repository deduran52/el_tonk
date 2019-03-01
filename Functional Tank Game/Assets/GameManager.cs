using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class GameManager : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //NOTE: Start() runs even before anyone connects to a server
    }
    [SyncVar]
    public float timeLeft = 180;
    // Update is called once per frame
    void Update()
    {
        if(isServer == false)
        {
            return;
        }

        //FOR NOW we just reset the map/players every 3 minutes
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            //restart the match
        }//end if
    }//end update
}
