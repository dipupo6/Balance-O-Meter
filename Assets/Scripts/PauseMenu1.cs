using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class PauseMenu1 : MonoBehaviour
{
   public GameObject PauseButton; 
   public GameObject ResumeButton;
   public GameObject Camera;
   
   public static bool IsGamePaused = false;

   public void Pause(){
       ResumeButton.SetActive(true);
       PauseButton.SetActive(false);
       Camera.GetComponent<CameraFollow>().enabled = false;
       Time.timeScale = 0;
       IsGamePaused = true;
   }

   public void Resume(){
       ResumeButton.SetActive(false);
       PauseButton.SetActive(true);
       Camera.GetComponent<CameraFollow>().enabled = true;
       Time.timeScale = 1; 
       IsGamePaused = false;
   }

   public static bool IsPointerOverUIObject()
   {
       PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
       eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
       List<RaycastResult> results = new List<RaycastResult>();
       EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
       return results.Count > 0;
   }
}
