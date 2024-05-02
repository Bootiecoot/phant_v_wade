using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 3.0f;


    void Start()
    {
        StartCoroutine(destroyTimer());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Vector3.right * Time.deltaTime;


    }


    IEnumerator destroyTimer()
    {
        yield return new WaitForSeconds(10);

        Destroy(gameObject);
    }

}
