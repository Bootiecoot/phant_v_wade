using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Chenault, Joshua / Melin, Ryan
/// 
/// 
/// This script is used by the shop prefab that tracks 
/// 
/// </summary>

public class ShopOperations : MonoBehaviour
{
    private string mouseState = "inactive";
    public int plantInUse = 0;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
        //if(MouseCursor)


    }

    private void OnMouseDown()
    {
        if (mouseState == "inactive")
        {
            mouseState = "active";
            print("now active");
        }
        else if (mouseState == "active")
        {
            mouseState = "inactive";
            print("nolonger active");
        }

    }
}
