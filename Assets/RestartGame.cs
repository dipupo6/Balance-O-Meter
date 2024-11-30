using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public GameObject Camera;
    public GameObject PauseButton;
    public GameObject GameText;
    public GameObject HighText;
    public GameObject ScoreText1;
    public GameObject ScoreText;
    public GameObject ScoreText2;
    public GameObject EventSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            SceneManager.LoadScene("RestartScene", LoadSceneMode.Additive);
            Time.timeScale = 0;
            Camera.GetComponent<CameraFollow>().enabled = false;
            GameText.SetActive(true);
            PauseButton.SetActive(false);
            HighText.SetActive(true);
            ScoreText1.SetActive(true);
            ScoreText.SetActive(false);
            EventSystem.SetActive(false);
            ScoreText2.GetComponent<TextMeshProUGUI>().enabled = true;
        }
    }
}
