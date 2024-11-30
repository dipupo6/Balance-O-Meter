using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawn : MonoBehaviour
{
    /*public Transform Player;*/
    public GameObject[] Obstacles;
    /*float randY;*/
    Vector3 whereToSpawn;
    public int sTime = 2;
    public float spawnRate = 1f;
    float nextSpawn = 0f;
    /*float moveSpawn = 0.2f;*/
    float spawnPos = 0.001f;
    // Add these variables for rotation
    public float minRotation = 0f;
    public float maxRotation = 360f;

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
            whereToSpawn = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
            // Generate a random rotation around the z-axis
            float randomRotation = Random.Range(minRotation, maxRotation);
            Quaternion rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, randomRotation);

            Instantiate (Obstacles[UnityEngine.Random.Range(0,6)], whereToSpawn, rotation);                                       
        }
    } 
        
}
