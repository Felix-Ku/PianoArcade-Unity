using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMA : MonoBehaviour
{

    public HealthBar healthBar;
	public int maxHealth = 100;
    public static int currentHealth;

    public GameObject gameoverUI;
    public GameObject ExitUI;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ExitGame();
        }
        healthBar.SetHealth(currentHealth);
        if (currentHealth<=0)
            EndGame();
    }

    public void EndGame()
    {
        Debug.Log(Score.score);
        PlayerPrefs.SetFloat ("Highscore", Score.score);
        Debug.Log("GameOver");
        gameoverUI.SetActive(true);
    }

    public void ExitGame()
    {
        ExitUI.SetActive(true);
    }
}
