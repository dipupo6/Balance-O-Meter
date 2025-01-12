using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    /*public Transform Player;*/
    public GameObject Cloud;
    float randX;
    float randZ;
    float randSpawn;
    Vector3 whereToSpawn;
    public int sTime = 2;
    public float spawnRate = 1f;
    float nextSpawn = 0f;
    /*float moveSpawn = 0.2f;*/
    public Transform Camera;

    // Start is called before the first frame update
    void Start()
    {
       
    } 

    void Update(){
        randSpawn = Random.Range(4f, 8f);
        transform.position = new Vector3(transform.position.x,
                                         Camera.position.y + randSpawn,
                                         transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;
            //randX = Random.Range (-6f, 6f);
            randZ = Random.Range (8f, 21f);
            whereToSpawn = new Vector3 (transform.position.x, transform.position.y, randZ);

            Instantiate (Cloud, whereToSpawn, Quaternion.identity);                                       
        }
    } 
        
}

