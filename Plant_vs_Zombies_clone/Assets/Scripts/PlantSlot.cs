using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlantSlot : MonoBehaviour
{

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
        // sets up current aspects of the player controller
        var playerCurrentState = player.GetComponent<PlayerController>().playerState;
        var playerSun = player.GetComponent<PlayerController>().sun;
        var plantCost = player.GetComponent<PlayerController>().selectedPlantCost;
        var plantSelected = player.GetComponent<PlayerController>().selectedPlant;

        if (playerCurrentState == "active" && playerSun >= plantCost)
        {
            player.GetComponent<PlayerController>().playerState = "inactive";
            player.GetComponent<PlayerController>().sun -= plantCost;
            print("slot selected");
        }
        

    }
}
