using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEnemySpawner : MonoBehaviour
{
    public GameObject basicEnemy;
    public GameObject hardEnemy;
    public GameObject spawnPointOne;

    public float spawnDelay;
    public float spawnRate;
    public float hardSpawnDelay;
    public float hardSpawnRate;
    public int spawnAmount;
    public int hardSpawnAmount;

    private Vector3 pointOne;

    // Start is called before the first frame update
    void Start()
    {
        pointOne = spawnPointOne.transform.position;
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnRate);
        InvokeRepeating("SpawnHardEnemy", hardSpawnDelay, hardSpawnRate);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnEnemy()
    {
      int randomNum = Random.Range(0, 1);
      spawnAmount += 1;
      if (randomNum == 0)
      {
         Instantiate(basicEnemy, pointOne, transform.rotation);
      }

    }

    private void SpawnHardEnemy()
    {
        int randomNum = Random.Range(0, 1);
        hardSpawnAmount += 1;
        if (randomNum == 0)
        {
            Instantiate(hardEnemy, pointOne, transform.rotation);
        }
    }
}
