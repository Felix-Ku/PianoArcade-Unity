using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SMenu : MonoBehaviour
{

    public Text highscore1;
    public Text highscore2;
    public Text highscore3;
    // Start is called before the first frame update
    void Start()
    {
        highscore1.text = "Highscore : " + PlayerPrefs.GetFloat("Highscore1");
        highscore2.text = "Highscore : " + PlayerPrefs.GetFloat("Highscore2");
        highscore3.text = "Highscore : " + PlayerPrefs.GetFloat("Highscore3");
    }

    
    // Update is called once per frame
    public void ToStudioGame1()
    {
        SceneManager.LoadScene("StudioMode 1");
    }
    public void ToStudioGame2()
    {
        SceneManager.LoadScene("StudioMode 2");
    }
        public void ToStudioGame3()
    {
        SceneManager.LoadScene("StudioMode 3");
    }

            public void ToStudioGame4()
    {
        SceneManager.LoadScene("StudioMode 4");
    }

        // Update is called once per frame
    public void MainMenuFromS()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Select (string levelName)
    {
        //fader.FadeTo(LevelName)
    }


}
