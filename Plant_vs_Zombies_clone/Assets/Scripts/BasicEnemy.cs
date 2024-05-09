using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

/// <summary>
/// Chenault, Joshua / Melin, Ryan
/// 5/2/2024
/// For basic and tough enemies.
/// </summary>
public class BasicEnemy : MonoBehaviour
{

    public float speed = 5.0f;
    public float health = 10.0f;
    private bool canMove = true;
    private Rigidbody rb;
    private GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        if (canMove == true)
        {
            rb.velocity = -(Vector3.right * speed);
        }
        else
        {
            rb.velocity = -(Vector3.right * 0);
        }

        if (health <= 0)
        {

            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        // this sees if the hit box is connecting with a plant, then sees if it can even be damaged.

        if (other.GetComponent<Projectile>() != null)
        {

            health -= 1;
            Destroy(other.gameObject);
        }

        if (other.GetComponent<PlantHp>() != null)
        {
            Debug.Log("triggerd");
            
            canMove = false;
            target = other.gameObject;
            
            StartCoroutine(attackTimer());
        }


    }

    IEnumerator attackTimer()
    {
        yield return new WaitForSeconds(0.5f);


        if (target != null)
        {
            target.GetComponent<PlantHp>().health--;
            StartCoroutine(attackTimer());
        }
        else
        {
            canMove = true;
        }
       
    }

}
