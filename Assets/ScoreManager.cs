using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score;
    private int lastScore;
    private int highScore;

    public Text scoreText;
    public 
    void Start()
    {
        score = 0;
        lastScore = PlayerPrefs.GetInt("LastScore", 0);
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    void Update()
    {


        scoreText.text = string.Format("Score: {0}\nLast: {1}\nHighest: {2}", score, lastScore , highScore);
        

    }

    public void AddScore(int points)
    {
        score += points;
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);

            scoreText.color = new Color(0.392f, 1f, 0.419f);
        }
        else
        {
            scoreText.color = Color.white;
        }
    }

    public void SetLastScore(int points)
    {
        lastScore = points;
        PlayerPrefs.SetInt("LastScore", lastScore);
    }

    public int GetScore()
    {
        return score;
    }
}