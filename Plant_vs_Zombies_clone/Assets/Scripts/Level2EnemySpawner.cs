using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2EnemySpawner : MonoBehaviour
{
    public GameObject basicEnemy;
    public GameObject hardEnemy;
    public GameObject teleportEnemy;
    public GameObject spawnPointOne;
    public GameObject spawnPointTwo;
    public GameObject spawnPointThree;
    public GameObject spawnPointFour;
    public GameObject spawnPointFive;

    public float spawnDelay;
    public float spawnRate;
    public float hardSpawnDelay;
    public float hardSpawnRate;
    public float teleportSpawnDelay;
    public float teleportSpawnRate;
    public int spawnAmount;
    public int hardSpawnAmount;
    public int teleportSpawnAmount;

    private Vector3 pointOne;
    private Vector3 pointTwo;
    private Vector3 pointThree;
    private Vector3 pointFour;
    private Vector3 pointFive;

    // Start is called before the first frame update
    void Start()
    {
        pointOne = spawnPointOne.transform.position;
        pointTwo = spawnPointTwo.transform.position;
        pointThree = spawnPointThree.transform.position;
        pointFour = spawnPointFour.transform.position;
        pointFive = spawnPointFive.transform.position;

        InvokeRepeating("SpawnEnemy", spawnDelay, spawnRate);
        InvokeRepeating("SpawnHardEnemy", hardSpawnDelay, hardSpawnRate);
        InvokeRepeating("SpawnTeleportEnemy", teleportSpawnDelay, teleportSpawnRate);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnEnemy()
    {
        int randomNum = Random.Range(0, 5);
        spawnAmount += 1;
        if (randomNum == 0)
        {
            Instantiate(basicEnemy, pointOne, transform.rotation);
        }
        else if (randomNum == 1)
        {
            Instantiate(basicEnemy, pointTwo, transform.rotation);
        }
        else if (randomNum == 2)
        {
            Instantiate(basicEnemy, pointThree, transform.rotation);
        }
        else if (randomNum == 3)
        {
            Instantiate(basicEnemy, pointFour, transform.rotation);
        }
        else if (randomNum == 4)
        {
            Instantiate(basicEnemy, pointFive, transform.rotation);
        }

    }

    private void SpawnHardEnemy()
    {
        int randomNum = Random.Range(0, 5);
        hardSpawnAmount += 1;
        if (randomNum == 0)
        {
            Instantiate(hardEnemy, pointOne, transform.rotation);
        }
        else if (randomNum == 1)
        {
            Instantiate(hardEnemy, pointTwo, transform.rotation);
        }
        else if (randomNum == 2)
        {
            Instantiate(hardEnemy, pointThree, transform.rotation);
        }
        else if (randomNum == 3)
        {
            Instantiate(hardEnemy, pointFour, transform.rotation);
        }
        else if (randomNum == 4)
        {
            Instantiate(hardEnemy, pointFive, transform.rotation);
        }
    }

    private void SpawnTeleportEnemy()
    {
        int randomNum = Random.Range(0, 5);
        teleportSpawnAmount += 1;
        if (randomNum == 0)
        {
            Instantiate(teleportEnemy, pointOne, transform.rotation);
        }
        else if (randomNum == 1)
        {
            Instantiate(teleportEnemy, pointTwo, transform.rotation);
        }
        else if (randomNum == 2)
        {
            Instantiate(teleportEnemy, pointThree, transform.rotation);
        }
        else if (randomNum == 3)
        {
            Instantiate(teleportEnemy, pointFour, transform.rotation);
        }
        else if (randomNum == 4)
        {
            Instantiate(teleportEnemy, pointFive, transform.rotation);
        }
    }
}
