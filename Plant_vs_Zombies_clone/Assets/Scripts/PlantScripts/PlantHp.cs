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
            Destroy(gameObject);
            if (spawnSlot != null)
            {
                spawnSlot.GetComponent<PlantSlot>().slotSelected = false;
            }
        }
    }

    public void healthLoose()
    {
        health--;
    }
}
