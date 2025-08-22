using JetBrains.Annotations;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pauseMenu;
    private GameObject bird;


    private void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player");
        


        if (isPaused)
        {
            
            Time.timeScale = 0;
        }
    }
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            BirdScript bird = player.GetComponent<BirdScript>();
            if (bird != null)
            {
                // Successfully found BirdScript
            }
            else
            {
                Debug.LogWarning("Player object found, but no BirdScript component attached!");
            }
        }
        else
        {
            Debug.LogWarning("No GameObject with tag 'Player' found!");
        }

        if (Input.GetKeyDown(KeyCode.Escape) && bird.GetComponent<BirdScript>().isAlive )
        {
            if (isPaused)
            {
                Cursor.visible = false; 
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }


    }

    public void resumeGame()
    {
        if (isPaused)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
            Debug.Log("Game Resumed!");
        }
    }

    public void pauseGame()
    {
        if (!isPaused)
        {
            Cursor.visible = true;
            pauseMenu.SetActive(true);
            Time.timeScale = 0; 
            isPaused = true;
            Debug.Log("Game Paused!");
        }
    }

    public void quit()
    {
        Application.Quit();
    }

    public bool IsPaused()
    {
        return isPaused;
    }
}
