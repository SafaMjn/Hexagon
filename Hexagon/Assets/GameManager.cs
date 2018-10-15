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

    private void Start()
    {
        
    }

    public void GameOver()
    {

        gameOverScreen.gameObject.SetActive(true);
        timer.gameObject.SetActive(false);
        score.text = "Time\n"+scoreText.GetComponentsInChildren<Text>()[0].text + scoreText.GetComponentsInChildren<Text>()[1].text;
        scoreText.gameObject.SetActive(false);
        Time.timeScale = 0f;
    }

    
}
