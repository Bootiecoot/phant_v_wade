using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunPickup : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        StartCoroutine(destroyTimer());
    }

    private void OnMouseDown()
    {
        player.GetComponent<PlayerController>().sun += 25;


        Destroy(gameObject);
    }


    IEnumerator destroyTimer()
    {
        yield return new WaitForSeconds(10);

        Destroy(gameObject);
    }


}
