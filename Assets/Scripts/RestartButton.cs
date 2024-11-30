using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    private Button restartButton;
    
    // Start is called before the first frame update
    void Start()
    {
        restartButton = GetComponent<Button>();
        restartButton.onClick.AddListener(RestartGame);
        
    }

    // Update is called once per frame
    private void RestartGame()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        Time.timeScale = 1;
        
    }
}
