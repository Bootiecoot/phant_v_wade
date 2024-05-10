using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


/// <summary>
/// Chenault, Joshua / Melin Ryan
/// 5/1/2024
/// This script is used by all plant slots for placing plants.
/// </summary>


public class PlantSlot : MonoBehaviour
{

    public GameObject player;
    public bool slotSelected = false;
    


    private void OnMouseDown()
    {
        
        if (slotSelected == false)
        {
            placeSelectedPlant();
        }

    }

    private void placeSelectedPlant()
    {
        // sets up current aspects of the player controller
        var playerCurrentState = player.GetComponent<PlayerController>().playerState;
        var playerSun = player.GetComponent<PlayerController>().sun;
        var plantCost = player.GetComponent<PlayerController>().selectedPlantCost;
        var plantSelected = player.GetComponent<PlayerController>().selectedPlant;

        print(playerSun);

        // if the mousestate is active and the player has enough sun the plant will be placed.
        if (playerCurrentState == "active" && playerSun >= plantCost)
        {
            player.GetComponent<PlayerController>().playerState = "inactive";
            player.GetComponent<PlayerController>().sun -= plantCost;
            GameObject spawn = Instantiate(plantSelected, transform.position, transform.rotation);
                spawn.GetComponent<PlantHp>().spawnSlot = gameObject;

            print("slot selected");
            slotSelected = true;

        }
    }
}
