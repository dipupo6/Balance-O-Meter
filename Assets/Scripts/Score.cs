using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
/*using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;*/

 public class Score : MonoBehaviour
 {
     public static int highscore;
     public static int score;
     TextMeshProUGUI text;
     
 
     // Set highscoreText up in the inspector.
     public TextMeshProUGUI highscoreText;
 
     void Awake()
     {
         text = GetComponent<TextMeshProUGUI>();
         score = 0;
         highscore = score;
         highscore = PlayerPrefs.GetInt("highscore");
          
     }
     
     void Start() {
           
            highscoreText.text = "Highscore: " + highscore;
            StartCoroutine(IncrementScoreRoutine());
     }

      IEnumerator IncrementScoreRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            score++;
        }
    }
    
    /*public void LoadBestScore()
    {
        PlayGamesPlatform.Instance.LoadScores(
             "CgkIycDb79kREAIQAQ",
             LeaderboardStart.PlayerCentered,
             1,
             LeaderboardCollection.Public,
             LeaderboardTimeSpan.AllTime,
         (LeaderboardScoreData data) =>
         {
             Debug.Log(data.Valid);
             Debug.Log(data.Id);
             Debug.Log(data.PlayerScore);
             Debug.Log(data.PlayerScore.userID);
             Debug.Log(data.PlayerScore.formattedValue);
             if (int.Parse(data.PlayerScore.formattedValue) > highscore)
             {
                 PlayerPrefs.SetInt("highscore", int.Parse(data.PlayerScore.formattedValue));
             }
             highscoreText.text = "Highscore: " + data.PlayerScore.formattedValue;
         });
    }*/

     void Update()
     {
         if (score > highscore)
         {
             highscore = score;
             PlayerPrefs.SetInt("highscore", highscore);
             
         }
         text.text = "" + score;
         
     }
 }