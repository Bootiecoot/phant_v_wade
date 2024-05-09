using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{


    public int health = 10;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) { 
        
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Projectile>() != null)
        {

            health -= 1;
            Destroy(other.gameObject);
        }
    }
}
