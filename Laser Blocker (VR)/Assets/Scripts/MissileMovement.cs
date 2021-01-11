using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMovement : MonoBehaviour
{

    public static float speed;

    //public Material[] color;
    public Material red,orange, yellow, green;

    

    Renderer ren;

    void Start()
    {
        ren = GetComponent<Renderer>();
        ren.enabled = true;        
    }


    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);

        if (Blockage.color >= 1 && Blockage.color <= 40)
        {
            ren.sharedMaterial = red;
        }
        else if (Blockage.color >= 41 && Blockage.color <= 80)
        {
            ren.sharedMaterial = orange;
        }
        else if (Blockage.color >= 81 && Blockage.color <= 120)
        {
            ren.sharedMaterial = yellow;
        }
        else if (Blockage.color >= 121)
        {
            ren.sharedMaterial = green;
        }
    }
}

