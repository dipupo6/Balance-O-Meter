using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    /*public Transform Player;*/
    public GameObject Cloud;
    float randX;
    float randZ;
    Vector3 whereToSpawn;
    public int sTime = 2;
    public float spawnRate = 1f;
    float nextSpawn = 0f;
    /*float moveSpawn = 0.2f;*/
    float spawnPos = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
       
    } 

    void Update(){
        transform.position = new Vector3(transform.position.x,
                                         transform.position.y + spawnPos,
                                         transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;
            /*if (Score.score < 5) 
            {
                randY = Random.Range (30f, 35f);
            }
            if (Score.score > 5) 
            {
                randY = Random.Range (25f, 40f);
            }*/
            randX = Random.Range (-6f, 6f);
            randZ = Random.Range (8f, 21f);
            whereToSpawn = new Vector3 (randX, transform.position.y, randZ);

            Instantiate (Cloud, whereToSpawn, Quaternion.identity);                                       
        }
    } 
        
}

