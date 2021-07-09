using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArcadeMenu : MonoBehaviour
{
    public Text highscoretext;
    // Start is called before the first frame update
    void Start()
    {
        highscoretext.text = "Highscore:" + ((int)PlayerPrefs.GetFloat("Highscore")).ToString() + " km";
    }

    // Update is called once per frame
    public void ToArcadeGame()
    {
        SceneManager.LoadScene("ArcadeMode");
    }

        // Update is called once per frame
    public void MainMenuFromA()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
