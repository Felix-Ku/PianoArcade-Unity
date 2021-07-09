using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public int scoreValue;
    public static int hit=0;
    public static int miss=0;
    private GameController gameController;

    void Start ()
    {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent <GameController>();
        }
        if (gameController == null)
        {
            Debug.Log ("Cannot find 'GameController' script");
        }
    }


    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        else if (other.tag == "PlayerPiano")
        {
            miss+=1;
            Instantiate(explosion, transform.position, transform.rotation);
            GameController.currentHealth -=10;
            Destroy(gameObject);
            return;
        }
        hit+=1;
        // For explosion effects
        Instantiate(explosion, transform.position, transform.rotation);
        gameController.AddScore (scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}