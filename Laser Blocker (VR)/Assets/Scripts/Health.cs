using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public static int lives;

    void Start()
    {
        lives = 3;
    }

    void Update()
    {
        DestroyMissile();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            lives -= 1;
            Blockage.color = 1;
            

            if (lives == 0)
            {
                print("GameOver");
                Destroy(other.gameObject);
                Time.timeScale = 0;
            }
        }

        print(lives);
        Destroy(other.gameObject);

    }

    void DestroyMissile()
    {
        if (lives == 0)
        {
            Destroy(GameObject.FindWithTag("Missile"));
        }
    }

}
