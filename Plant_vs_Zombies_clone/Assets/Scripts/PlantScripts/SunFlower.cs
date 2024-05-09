using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunFlower : MonoBehaviour
{
    public GameObject point;
    public GameObject sunObject;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnSun", 6.0f , 12.0f);
    }

   

    private void spawnSun()
    {
        GameObject spawn = Instantiate(sunObject, point.transform.position, transform.rotation);
    }
}
