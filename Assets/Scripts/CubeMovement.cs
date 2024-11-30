using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
     public float speed = 5f;
     private Rigidbody rb;
     private bool constraintsFrozen = false;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (!constraintsFrozen)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
            transform.Translate(movement * speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter (){
        GetComponent<RotateOnTap>().enabled = false;
        if (rb != null)
        {
            StartCoroutine(FreezeConstraintsAfterDelay(10f));
        }
    }

    IEnumerator FreezeConstraintsAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        FreezeAllConstraints();
    }

    void FreezeAllConstraints()
    {
        if (rb != null)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            constraintsFrozen = true;
            Debug.Log("All Rigidbody constraints frozen after 10 seconds");
        }
    }

    /*void OnTriggerEnter(Collider coll){
        if (coll.gameObject.CompareTag("Destroy")){

        }
    }*/
}
