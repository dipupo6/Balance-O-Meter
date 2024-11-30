using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FreezeUnfreezeManager : MonoBehaviour
{
    public float freezeDuration = 15f;
    public float unfreezeDuration = 1f;

    private List<Rigidbody> rigidbodies = new List<Rigidbody>();

    void Start()
    {
        StartCoroutine(FreezeUnfreezeCoroutine());
    }

    void Update()
    {
        Rigidbody[] newRigidbodies = FindObjectsOfType<Rigidbody>();
        foreach (Rigidbody rb in newRigidbodies)
        {
            if (!rigidbodies.Contains(rb))
            {
                rigidbodies.Add(rb);
            }
        }
    }

    IEnumerator FreezeUnfreezeCoroutine()
    {
        while (true)
        {
            SetXZFreeze(true);
            yield return new WaitForSeconds(freezeDuration);

            SetXZFreeze(false);
            yield return new WaitForSeconds(unfreezeDuration);
        }
    }

    void SetXZFreeze(bool freeze)
    {
        foreach (Rigidbody rb in rigidbodies)
        {
            if (rb != null)
            {
                if (freeze)
                {
                    rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | rb.constraints;
                }
                else
                {
                    rb.constraints &= ~(RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ);
                }
            }
        }
    }
}