using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int scorePerPipe;
    public GameObject gameOverScreen;
    private PauseGame pauseManager;
    private ScoreManager scoreManager;

    private void Start()
    {
        Application.targetFrameRate = 60;
        pauseManager = GetComponent<PauseGame>();
        scoreManager = GetComponent<ScoreManager>();

        Cursor.visible = false; 
    }

    

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        GetComponent<ScoreManager>().AddScore(scorePerPipe);
    }

    public void addScore(int scoreToAdd)
    {
        GetComponent<ScoreManager>().AddScore(scoreToAdd);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if (scoreManager == null)
        {
            scoreManager = GetComponent<ScoreManager>(); 
        }

        scoreManager.SetLastScore(GetComponent<ScoreManager>().GetScore());
        if (gameOverScreen != null)
        {
            Cursor.visible = true;
            gameOverScreen.SetActive(true);
        }
        else
        {
            Debug.LogError("GameOverScreen is not assigned in the inspector!");
        }
    }
}
