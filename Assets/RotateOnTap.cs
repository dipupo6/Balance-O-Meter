using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class RotateOnTap : MonoBehaviour
{
    public float rotationAmount = 10f; // Degrees to rotate per tap

    void Update()
    {
        // Check for touch input on mobile devices
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (!PauseMenu1.IsGamePaused && !PauseMenu1.IsPointerOverUIObject())
            {
                RotateObject();
            }
        }
        
        // Check for mouse input (for testing in the Unity editor)
        if (Input.GetMouseButtonDown(0))
        {
            if (!PauseMenu1.IsGamePaused && !PauseMenu1.IsPointerOverUIObject())
            {
                RotateObject();
            }
        }
    }

    void RotateObject()
    {
        // Rotate the object around its up axis (y-axis in most cases)
        transform.Rotate(Vector3.forward, rotationAmount);
    }
}
