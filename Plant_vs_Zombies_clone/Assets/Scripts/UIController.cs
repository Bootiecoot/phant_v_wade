    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{

    public PlayerController playerController;
    public TMP_Text sunText;
    public TMP_Text costText;
    public TMP_Text plantText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sunText.text = "Sun: " + playerController.sun.ToString();
        costText.text = "Selected Plant Cost: " + playerController.selectedPlantCost.ToString();
        plantText.text = "Selected Plant: " + playerController.selectedPlant.ToString();
    }
}
