using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfiniteSpawn : MonoBehaviour
{

    public AudioSource laserPew;

    public GameObject missilePrefab, playerHitBox;

    public float respawnTime;
    public float minusTime;

    public float xMin, xMax, yMin, yMax, zPos;   
    

    void Start()
    {
        respawnTime = 1f;
        minusTime = 0.1f;     
                
        StartCoroutine(infiniteMode());
        StartCoroutine(respawnTimeDecrease());

        MissileMovement.speed = 10f;
    }  
    void SpawnMissile()
    {
        float xPos = Random.Range(xMin, xMax);
        float yPos = Random.Range(yMin, yMax);


        Vector3 spawnPos = new Vector3(xPos, yPos, zPos);

       

        Instantiate(missilePrefab, spawnPos, Quaternion.Euler(90, 0, 0));        
    }     
    
    IEnumerator infiniteMode()
    {
        SpawnMissile();
        yield return new WaitForSeconds(respawnTime);
        StartCoroutine(infiniteMode());
    }  

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawSphere(new Vector3(xMin, yMin, zPos), 0.25f);
        Gizmos.DrawSphere(new Vector3(xMin, yMax, zPos), 0.25f);
        Gizmos.DrawSphere(new Vector3(xMax, yMin, zPos), 0.25f);
        Gizmos.DrawSphere(new Vector3(xMax, yMax, zPos), 0.25f);
    }

    IEnumerator respawnTimeDecrease()
    {
        yield return new WaitForSeconds(10f);
        if (respawnTime > 0.3f)
        {
            respawnTime -= 0.1f;            
        }
        StartCoroutine("respawnTimeDecrease");

    }
    

}
