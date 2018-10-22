using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject gameOverScreen;
    public Text score;
    public GameObject scoreText;
    public GameObject timer;
    public float highScore;
    public Text highScoreText;

    private void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore");
       // if (highScore>0)
        //{
            highScoreText.text = "Highscore\n" + highScore.ToString("f2");
       // }
       
    }
    public void GameOver()
    {
        gameOverScreen.gameObject.SetActive(true);
        timer.gameObject.SetActive(false);
        score.text = "Time\n" + scoreText.GetComponent<Text>().text;
        scoreText.gameObject.SetActive(false);

        var hs = PlayerPrefs.GetFloat("HighScore");
        Debug.Log(hs);
        if (Timer.timer > hs)
        {
            PlayerPrefs.SetFloat("HighScore", Timer.timer);
            PlayerPrefs.Save();
        }
        Debug.Log(PlayerPrefs.GetFloat("HighScore"));
        Time.timeScale = 0f;
    }

    private void Update()
    {
     if (Timer.timer > highScore)
        {
            highScoreText.text = "Highscore\n" + Timer.timer.ToString("f2");
        }
            
    }


}
