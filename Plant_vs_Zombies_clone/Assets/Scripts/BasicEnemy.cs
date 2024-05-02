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
    public Transform target;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        rb.velocity = -(Vector3.right * speed);

    }

}
