using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRandomizer : MonoBehaviour
{
    public Material[] materials;
    // Start is called before the first frame update
    void Start()
    {
        SetRandomTexture();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetRandomTexture() {
        int index = Random.Range(0, 2);

        switch (index)
        {
            case 0:
                GetComponent<Renderer>().material = materials[0];
                break;
            case 1:
                GetComponent<Renderer>().material = materials[1];
                break;	 
        }
    }
}
