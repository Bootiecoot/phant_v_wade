using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Chenault, Joshua / Melin, Ryan
/// 
/// 
/// This script is used by the shop prefab that tracks 
/// 
/// </summary>

public class ShopOperations : MonoBehaviour
{
    private string mouseState = "inactive";
    public GameObject plantInUse;
    public int plantCost = 0;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
         


    }

    private void OnMouseDown()
    {
        var playerCurrentState = player.GetComponent<PlayerController>().playerState;

        if (playerCurrentState == "inactive")
        {
            
            player.GetComponent<PlayerController>().playerState = "active";
            player.GetComponent<PlayerController>().selectedPlantCost = plantCost;
            //player.GetComponent<PlayerController>().selectedPlant =
            print("now active");
        }
        else if (playerCurrentState == "active")
        {
           
            player.GetComponent<PlayerController>().playerState = "inactive";
            print("nolonger active");
        }

    }
}
