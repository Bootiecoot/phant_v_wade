using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Chenault, Joshua / Melin, Ryan
/// 5/1/2024
/// This script is used by the shop prefab that tracks 
/// 
/// </summary>

public class ShopOperations : MonoBehaviour
{
    private string mouseState = "inactive";
    public GameObject plantInUse;
    public int plantCost = 0;
    public GameObject player;
 

    /// <summary>
    /// When clicking on the shop is "equips" the plant to a manager script that slots and the shops pull from.
    /// </summary>
    private void OnMouseDown()
    {
        var playerCurrentState = player.GetComponent<PlayerController>().playerState;

        if (playerCurrentState == "inactive")
        {
            
            player.GetComponent<PlayerController>().playerState = "active";
            player.GetComponent<PlayerController>().selectedPlantCost = plantCost;
            player.GetComponent<PlayerController>().selectedPlant = plantInUse;
            print("now active");
        }
        else if (playerCurrentState == "active")
        {
           
            player.GetComponent<PlayerController>().playerState = "inactive";
            print("nolonger active");
        }

    }
}
