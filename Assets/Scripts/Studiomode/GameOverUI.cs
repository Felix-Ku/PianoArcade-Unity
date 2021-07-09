using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public void Quit ()
    {
        if (SceneManager.GetActiveScene().name=="ArcadeMode")
            SceneManager.LoadScene("ArcadeMenu");
        if (SceneManager.GetActiveScene().name[0]=='S')
            SceneManager.LoadScene("StudioMenu");
        Debug.Log (SceneManager.GetActiveScene().name);
        // Application.Quit();
    }

    public void Retry ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
