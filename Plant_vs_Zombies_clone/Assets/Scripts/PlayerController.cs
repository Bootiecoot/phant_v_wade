using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// Chenault, Joshua / Melin, Ryan
/// 5/1/2024
/// This script is on a object that is called on by all shops and slots.
/// 
/// </summary>

public class PlayerController : MonoBehaviour
{
    public string playerState = "inactive";
    public int sun = 50;
    public GameObject selectedPlant;
    public int selectedPlantCost = 0;
    public int lives = 1;


    public void Death()
    {
        lives--;
        if(lives == 0)
        {
            SceneManager.LoadScene(1);
        }

    }

}
