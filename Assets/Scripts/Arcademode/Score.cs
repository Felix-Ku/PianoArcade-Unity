using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using MidiJack;

public class Score : MonoBehaviour
{
    public PlayerMotor playermotor;
    public static float score = 0.0f;

    private int difficultyLevel = 5;
    private int maxDifficultyLevel = 20;
    private int scoreToNextLevel = 20;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(score>= scoreToNextLevel)
        {
            LevelUp();
        }

        score += Time.deltaTime;
        scoreText.text = ((int)score).ToString ()+" Km";
    }

    void LevelUp()
    {
        if (difficultyLevel==maxDifficultyLevel)
            return;
        
        scoreToNextLevel *=2;
        difficultyLevel++;

        GetComponent<PlayerMotor>().SetSpeed (difficultyLevel);
    }
    
}
