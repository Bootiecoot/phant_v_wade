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
    public Level2EnemySpawner lv2EnemySpawner;

    public void Start()
    {
        
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
            if (enemySpawner.spawnAmount == 15 && enemySpawner.hardSpawnAmount == 10)
            {
                DestroyImmediate(firstSpawner, true);

                StartCoroutine(Level2());
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level 2")
        {
            if (enemySpawner.spawnAmount == 15 && enemySpawner.hardSpawnAmount == 10 && lv2EnemySpawner.teleportSpawnAmount == 5)
            {
                DestroyImmediate(firstSpawner, true);

                StartCoroutine(Level3());
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level 3")
        {
            if (enemySpawner.spawnAmount == 20 && enemySpawner.hardSpawnAmount == 15 && lv2EnemySpawner.teleportSpawnAmount == 10)
            {
                DestroyImmediate(firstSpawner, true);

                StartCoroutine(End());

            }
        }
        
    }

    public void Death()
    {
        lives--;
        if(lives == 0)
        {
            SceneManager.LoadScene(5);
        }
    }

    IEnumerator Level2()
    {
        yield return new WaitForSeconds(12);

        SceneManager.LoadScene(3);
    }

    IEnumerator Level3()
    {
        yield return new WaitForSeconds(12);

        SceneManager.LoadScene(4);
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(12);

        SceneManager.LoadScene(6);
    }

}
