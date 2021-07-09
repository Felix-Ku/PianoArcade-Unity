using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValues;
    public float SpawnZ;

    public Text scoreText;
    public Text noteText;
    public int score;

    public Text hittext;
	public Text misstext;
    public GameObject completeUI;


    public HealthBar healthBar;
	public int maxHealth = 100;
    public static int currentHealth;

    public GameObject gameoverUI;
    public GameObject ExitUI;
    
    void Start ()
    {
        score=0;
        UpdateScore();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }
    void Update ()
    {
        healthBar.SetHealth(GameController.currentHealth);
        if (currentHealth<=0)
            EndGame();
        if (MidiPlayer.over==true)
        {
            if (GameObject.FindWithTag("Jelly") == null)
		    {
			    CheckComplete();
		    }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
            ExitGame();
        }
        
        
    }
    public void EndGame()
    {
        PlayerPrefs.SetFloat("Highscore1", score);
        Debug.Log("GameOver");
        gameoverUI.SetActive(true);
    }
    public void ExitGame()
    {
        ExitUI.SetActive(true);
    }

    void CheckComplete()
	{

		if(currentHealth>0)
		{
			hittext.text="HIT: "+DestroyByContact.hit;
			misstext.text="MISS: "+DestroyByContact.miss;
			completeUI.SetActive(true);
		}
			
	}
    			

    public void SpawnWaves (string MidiNotesInput)
    {
            noteText.text="Current Note: " + MidiNotesInput;
            if (MidiNotesInput!=""){
            if (MidiNotesInput[0]=='C')
            {
                if (MidiNotesInput=="C5")
                    SpawnZ=-0.863f;
                else if (MidiNotesInput=="C#5")
                    SpawnZ=-0.881f;
                else if (MidiNotesInput=="C6")
                    SpawnZ=-0.6378f;
                else if (MidiNotesInput=="C#6")
                    SpawnZ=-0.6206f;
                else if (MidiNotesInput[1]=='#')
                    SpawnZ=-0.881f;
                else
                {
                    SpawnZ=-0.863f;
                }
            }
            else if (MidiNotesInput[0]=='D')
            {
                if (MidiNotesInput=="D5")
                    SpawnZ=-0.827f;
                else if (MidiNotesInput=="D#5")
                    SpawnZ=-0.846f;
                else if (MidiNotesInput=="D6")
                    SpawnZ=-0.6038f;
                else if (MidiNotesInput=="D#6")
                    SpawnZ=-0.5865f;
                else if (MidiNotesInput[1]=='#')
                    SpawnZ=-0.846f;
                else
                {
                    SpawnZ=-0.827f;
                }
            }
            else if (MidiNotesInput[0]=='E')
            {
                if (MidiNotesInput=="E5")
                    SpawnZ=-0.79f;
                else if (MidiNotesInput=="E#5")
                    SpawnZ=-0.809f;
                else if (MidiNotesInput=="E6")
                    SpawnZ=-0.566f;
                else if (MidiNotesInput=="E#6")
                    SpawnZ=-0.5519f;
                else if (MidiNotesInput[1]=='#')
                    SpawnZ=-0.809f;
                else
                {
                    SpawnZ=-0.79f;
                }
            }
            else if (MidiNotesInput[0]=='F')
            {
                if (MidiNotesInput=="F5")
                    SpawnZ=-0.758f;
                else if (MidiNotesInput=="F#5")
                    SpawnZ=-0.771f;
                else if (MidiNotesInput=="F6")
                    SpawnZ=-0.5353f;
                else if (MidiNotesInput=="F#6")
                    SpawnZ=-0.5175f;
                else if (MidiNotesInput[1]=='#')
                    SpawnZ=-0.771f;
                else
                {
                    SpawnZ=-0.758f;
                }
            }
            else if (MidiNotesInput[0]=='G')
            {
                if (MidiNotesInput=="G5")
                    SpawnZ=-0.724f;
                else if (MidiNotesInput=="G#5")
                    SpawnZ=-0.741f;
                else if (MidiNotesInput=="G6")
                    SpawnZ=-0.4984f;
                else if (MidiNotesInput=="G#6")
                    SpawnZ=-0.4819f;
                else if (MidiNotesInput[1]=='#')
                    SpawnZ=-0.741f;
                else
                {
                    SpawnZ=-0.724f;
                }
            }
            else if (MidiNotesInput[0]=='A')
            {
                if (MidiNotesInput=="A5")
                    SpawnZ=-0.687f;
                else if (MidiNotesInput=="A#5")
                    SpawnZ=-0.705f;
                else if (MidiNotesInput=="A6")
                    SpawnZ=-0.4641f;
                else if (MidiNotesInput=="A#6")
                    SpawnZ=-0.4482f;
                else if (MidiNotesInput[1]=='#')
                    SpawnZ=-0.705f;
                else
                {
                    SpawnZ=-0.687f;
                }
            }
            else if (MidiNotesInput[0]=='B')
            {
                if (MidiNotesInput=="B5")
                    SpawnZ=-0.653f;
                else if (MidiNotesInput=="B#5")
                    SpawnZ=-0.67f;
                else if (MidiNotesInput=="B6")
                    SpawnZ=-0.4284f;
                else if (MidiNotesInput=="B#6")
                    SpawnZ=-0.4112f;
                else if (MidiNotesInput[1]=='#')
                    SpawnZ=-0.67f;
                else
                {
                    SpawnZ=-0.653f;
                }
            }

            Vector3 spawnPosition = new Vector3 (SpawnZ, spawnValues.y, spawnValues.z);
            Instantiate (hazard, spawnPosition, transform.rotation * Quaternion.Euler (0f, 180f, 0f));
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore ();
    }

    void UpdateScore ()
    {
        scoreText.text="Score: " + score;
    }
}




