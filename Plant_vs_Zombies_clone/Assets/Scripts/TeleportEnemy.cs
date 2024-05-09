using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TeleportEnemy : MonoBehaviour
{

    private bool hasTeleported = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("teleportToPosition", 4f, 30f);
    }

    private void teleportToPosition() 
    {
        if(hasTeleported == false)
        {
            while (hasTeleported == false)
            {
                int randomNumber = Random.Range(0, 4);
                if (randomNumber == 0 && transform.position.z != -3.17)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, -3.17f);
                    hasTeleported = true;
                }
                else if (randomNumber == 1 && transform.position.z != -1.171)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, -1.171f);
                    hasTeleported = true;
                }
                else if (randomNumber == 1 && transform.position.z != 0.788)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, 0.788f);
                    hasTeleported = true;
                }
                else if (randomNumber == 1 && transform.position.z != 2.722)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, 2.722f);
                    hasTeleported = true;
                }
                else if (randomNumber == 1 && transform.position.z != 4.711)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, 4.711f);
                    hasTeleported = true;
                }
            }
            
            

            
        }

    
    }

}
