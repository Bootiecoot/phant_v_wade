using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Chenault, Joshua / Melin, Ryan
/// 5/2/2024
/// for the basic shooting plant
/// </summary>


public class PlantShooter : MonoBehaviour
{

    public GameObject projectile;
    public float firerate = 2.0f;
    public GameObject spawnPoint;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnBullet", firerate, firerate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnBullet()
    {

        
        GameObject spawn = Instantiate(projectile, spawnPoint.transform.position ,transform.rotation);
        spawn.GetComponent<PlantHp>().spawnSlot = gameObject;
       
    }
}
