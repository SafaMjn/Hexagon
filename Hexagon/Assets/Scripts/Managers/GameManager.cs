using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager> {

    public GameObject gameOverScreen;
    public Text score;
    public GameObject scoreText;
    public GameObject timer;
    public float highScore;
    public Text highScoreText;

    private void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore");
        highScoreText.text = "Highscore\n" + highScore.ToString("f2");
        gameOverScreen.SetActive(false);
    }
    public void GameOver()
    {
        gameOverScreen.gameObject.SetActive(true);
        timer.gameObject.SetActive(false);
        score.text = "Time\n" + scoreText.GetComponent<Text>().text;
        scoreText.gameObject.SetActive(false);

        var hs = PlayerPrefs.GetFloat("HighScore");
        if (Time_ctr.Instance.timer > hs)
        {
            PlayerPrefs.SetFloat("HighScore", Time_ctr.Instance.timer);
            PlayerPrefs.Save();
        }

        Time.timeScale = 0f;
    }

    private void Update()
    {
     if (Time_ctr.Instance.timer > highScore)
        {
            highScoreText.text = "Highscore\n" + Time_ctr.Instance.timer.ToString("f2");
        }
            
    }
    public void ReloadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
