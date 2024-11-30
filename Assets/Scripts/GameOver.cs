using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
        }

        
    }   

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Clear"))
        {
            Destroy(gameObject);
            Debug.Log("Collision");
        }
    }   
}
