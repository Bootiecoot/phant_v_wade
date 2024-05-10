using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantHp : MonoBehaviour
{
    public GameObject spawnSlot;
    public int health = 5;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            if (spawnSlot != null)
            {
                Debug.Log("reset slot");
                spawnSlot.GetComponent<PlantSlot>().slotSelected = false;
            }
            Destroy(gameObject);
            
        }
    }

    public void healthLoose()
    {
        health--;
    }
}
