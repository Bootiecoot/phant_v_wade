using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantHp : MonoBehaviour
{

    public int health = 5;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void healthLoose()
    {
        health--;
    }
}
