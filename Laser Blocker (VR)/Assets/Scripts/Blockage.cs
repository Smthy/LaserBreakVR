using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockage : MonoBehaviour
{

    public AudioSource laserBreak;

    public int score, scoreFinal;
    
    public static int color, broke, counter;  
    
    void Awake()
    {
        broke = 0;
        color = 1;
        score = 0;
        scoreFinal = 0;
    }

    
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.CompareTag("Missile"))
        {
            //broke += 1;
            //score += combo;

            color += 1;
            
            if (broke >= 0 && broke <= 20)
            {
                broke += 1;
            }
            else if (broke >= 21 && broke <= 250)
            {
                broke += 2;
            }
            else if (broke >= 251 && broke <= 1000)
            {
                broke += 4;
            }
            else if (broke >= 1001 && broke <= 2500)
            {
                broke += 8;
            }
            else if (broke >= 2501 && broke <= 8000)
            {
                broke += 16;
            }
            else if (broke >= 8001 && broke <= 16000)
            {
                broke += 32;
            }
            else if (broke >= 16001 && broke <= 28000)
            {
                broke += 64;
            }
            else if (broke >= 28001 && broke <= 40000)
            {
                broke += 128;
            }
            else if (broke >= 40001)
            {
                broke += 256;
            }

            score = broke;
            
            print("score " +score);
           
            Destroy(hit.gameObject);
        }        
    }     
}
