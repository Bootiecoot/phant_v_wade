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
    public GameObject secondSpawner;
    public EnemySpawner enemySpawner;

    public void Start()
    {
        secondSpawner.SetActive(false);

    }

    public void Update()
    {
        if(enemySpawner.spawnAmount == 1 && enemySpawner.hardSpawnAmount == 1)
        {
            enemySpawner.spawnAmount = 0;
            enemySpawner.hardSpawnAmount = 0;
            enemySpawner.hardSpawnRate = 10;
            enemySpawner.spawnRate = 10;
        }

        if (enemySpawner.spawnAmount == 2 && enemySpawner.hardSpawnAmount == 2)
        {
            enemySpawner.spawnAmount = 0;
            enemySpawner.hardSpawnAmount = 0;
            enemySpawner.hardSpawnRate = 20;
            enemySpawner.spawnRate = 20;
        }
    }

    public void Death()
    {
        lives--;
        if(lives == 0)
        {
            SceneManager.LoadScene(1);
        }

    }

    IEnumerator newWave()
    {
        yield return new WaitForSeconds(4);

        secondSpawner.SetActive(true);
    }

}
