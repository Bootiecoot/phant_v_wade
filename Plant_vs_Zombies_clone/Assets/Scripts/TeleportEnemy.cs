using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEnemy : MonoBehaviour
{

    private bool hasTeleported = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("", 4f, 30f);
    }

    private void teleportToPosition() 
    {
        if(hasTeleported == false)
        {

            float randomNumber = Random.Range(0, 4);
            //randomNumber.
        }

    
    }

}
