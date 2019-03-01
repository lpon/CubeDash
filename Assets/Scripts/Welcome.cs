using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    public void StartGame ()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
