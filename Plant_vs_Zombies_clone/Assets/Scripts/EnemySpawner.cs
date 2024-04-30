using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject spawnPointOne;
    public GameObject spawnPointTwo;
    public GameObject spawnPointThree;
    public GameObject spawnPointFour;
    public GameObject spawnPointFive;
    public float spawnDelay;
    public float spawnRate;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy()
    {
        int randomNum = Random.Range(0, 5);
        if (randomNum == 0)
        {
            Instantiate(enemy, pointOne, transform.rotation);
        }
        else if (randomNum == 1)
        {
            Instantiate(enemy, pointTwo, transform.rotation);
        }
        else if (randomNum == 2)
        {
            Instantiate(enemy, pointThree, transform.rotation);
        }
        else if (randomNum == 3)
        {
            Instantiate(enemy, pointFour, transform.rotation);
        }
        else if (randomNum == 4)
        {
            Instantiate(enemy, pointFive, transform.rotation);
        }
    }
}
