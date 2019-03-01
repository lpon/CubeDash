using UnityEngine;

public class Exit : MonoBehaviour
{
    public void Start ()
    {
        Debug.Log("Script loaded");
    }

    public void Quit ()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void HelpDebug ()
    {
        Debug.Log("help me");
    }
}
