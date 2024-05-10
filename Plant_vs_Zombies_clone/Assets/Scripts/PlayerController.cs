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
    public GameObject firstSpawner;
    
    public EnemySpawner enemySpawner;

    public void Start()
    {
        
    }

    public void Update()
    {
        if(enemySpawner.spawnAmount == 15 && enemySpawner.hardSpawnAmount == 10)
        {
            DestroyImmediate(firstSpawner, true);
            
            StartCoroutine(NewWave());
        }
    }

    public void Death()
    {
        lives--;
        if(lives == 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    IEnumerator NewWave()
    {
        yield return new WaitForSeconds(12);

        SceneManager.LoadScene(2);
    }

}
