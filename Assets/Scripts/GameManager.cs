using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded;
    public float startDelay = 2f;
    public float restartDelay = 3f;
    public PlayerMovement movement;
    public GameObject levelCompleteUI;
    public GameObject startLevelUI;
    public GameObject gameOverUI;

    private void Start()
    {
        startLevelUI.SetActive(true);
        gameOverUI.SetActive(false);
        movement.enabled = false;
        Invoke("StartGame", startDelay);
    }

    public void StartGame()
    {
        startLevelUI.SetActive(false);
        movement.enabled = true;
    }

    public void EndGame ()
    {
        if (!gameHasEnded)
        {
            movement.enabled = false;
            gameOverUI.SetActive(true);
            gameHasEnded = true;
            Invoke("RestartGame", restartDelay);
        }
    }

    public void RestartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel ()
    {
        gameHasEnded = true;
        movement.enabled = false;
        levelCompleteUI.SetActive(true);
    }
}
