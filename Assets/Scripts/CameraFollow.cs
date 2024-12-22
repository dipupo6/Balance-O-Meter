using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    // The Target
    /*public Transform target;*/
    float spawnPos = 0.0004f;

    void Start()
    {

    }

    void Update ()
    {
        transform.position = new Vector3(transform.position.x,
                                         transform.position.y + spawnPos,
                                         transform.position.z);
    }


    /*public void MoveCamera () {
        transform.position = new Vector3(transform.position.x,
                                         transform.position.y + spawnPos,
                                         transform.position.z);
    }*/
}
