using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

namespace MidiJack
{

public class PlayerMotor : MonoBehaviour
{

    public GameObject explosion;
    public Renderer playerrenderer;
    private float flashcounter;
    public float flashlength =0.1f;
    private float startTime;

    private CharacterController controller;
    private Vector3 moveVector;

    public float invinciblelength;
    private float invincinblecounter;

    // meters per second
    public float speed = 15.0f;

    // For camera animation
    private float animationDuration = 15.0f;
    private string temp;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController> ();
        startTime=Time.time;
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (invincinblecounter>0)
        {
            invincinblecounter-=Time.deltaTime;

            flashcounter-=Time.deltaTime;
            if (flashcounter <=0)
            {
                playerrenderer.enabled= !playerrenderer.enabled;
                flashcounter=flashlength;
            }

            if (invincinblecounter <= 0)
            {
                playerrenderer.enabled=true;
            }
        }
            

        // Fix the animation and player movement within the beginning camera animation
        if (Time.time-startTime < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;

        }

        moveVector =  Vector3.zero;
        moveVector.z = speed;

        controller.Move(moveVector * Time.deltaTime);
        #region Editor Support
        #if UNITY_EDITOR
        // To check the input of midi signals
        foreach (var message in MidiDriver.Instance.History)
            temp = (message.ToString().Substring(8,2));
        MidiDriver.Instance.History.Clear();
         #endif
        #endregion

        Vector3 move = transform.position;
        float step = speed * Time.deltaTime;
        switch (temp)
        {
            case "30":
               // Debug.Log("30");
                move = new Vector3(-15.29f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "31":
                //Debug.Log("34");
                move = new Vector3(-14.09f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "32":
               // Debug.Log("32");
                move = new Vector3(-12.9f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "33":
                //Debug.Log("33");
                move = new Vector3(-11.48f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "34":
                //Debug.Log("34");
                move = new Vector3(-10.12f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "35":
                //Debug.Log("35");
                move = new Vector3(-7.7f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
             case "36":
                //Debug.Log("37");
                move = new Vector3(-5.8f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "37":
                //Debug.Log("37");
                move = new Vector3(-3.96f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
             case "38":
                //Debug.Log("37");
                move = new Vector3(-2.64f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "39":
                //Debug.Log("39");
                move = new Vector3(-1.38f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "3A":
                //Debug.Log("3B");
                move = new Vector3(0f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break; 
            case "3B":
                //Debug.Log("3B");
                move = new Vector3(-1.32f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "3C":
                //Debug.Log("3C");
                move = new Vector3(3.8f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "3D":
                //Debug.Log("3B");
                move = new Vector3(5.68f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "3E":
                //Debug.Log("3E");
                move = new Vector3(7.68f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "3F":
                //Debug.Log("3E");
                move = new Vector3(8.99f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "40":
                //Debug.Log("40");
                move = new Vector3(10.15f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "41":
                //Debug.Log("41");
                move = new Vector3(12.9f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "42":
                //Debug.Log("42");
                move = new Vector3(14.17f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            case "43":
                //Debug.Log("43");
                move = new Vector3(15.29f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                break;
            default:
                //Debug.Log("NO INPUT");
                break;
        }
        
        if (Input.GetKey(KeyCode.Q))
        {
               // Debug.Log("30");
                move = new Vector3(-15.29f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.Keypad2))
        {
                //Debug.Log("34");
                move = new Vector3(-14.09f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
           if (Input.GetKey(KeyCode.W))
        {
               // Debug.Log("32");
                move = new Vector3(-12.9f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
           if (Input.GetKey(KeyCode.Keypad3))
        {
                //Debug.Log("33");
                move = new Vector3(-11.48f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.E))
        {
                //Debug.Log("34");
                move = new Vector3(-10.12f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.R))
        {
                //Debug.Log("35");
                move = new Vector3(-7.7f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
             if (Input.GetKey(KeyCode.Keypad5))
        {
                //Debug.Log("37");
                move = new Vector3(-5.8f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.T))
        {
                //Debug.Log("37");
                move = new Vector3(-3.96f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
             if (Input.GetKey(KeyCode.Keypad6))
        {
                //Debug.Log("37");
                move = new Vector3(-2.64f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.Y))
        {
                //Debug.Log("39");
                move = new Vector3(-1.38f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.Keypad7))
        {
                //Debug.Log("3B");
                move = new Vector3(0f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                } 
           if (Input.GetKey(KeyCode.U))
        {
                //Debug.Log("3B");
                move = new Vector3(-1.32f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.I))
        {
                //Debug.Log("3C");
                move = new Vector3(3.8f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.Keypad9))
        {
                //Debug.Log("3B");
                move = new Vector3(5.68f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.O))
        {
                //Debug.Log("3E");
                move = new Vector3(7.68f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.Keypad0))
        {
                //Debug.Log("3E");
                move = new Vector3(8.99f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.P))
        {
                //Debug.Log("40");
                move = new Vector3(10.15f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.LeftBracket))
        {
                //Debug.Log("41");
                move = new Vector3(12.9f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.Equals))
        {
                //Debug.Log("42");
                move = new Vector3(14.17f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
            if (Input.GetKey(KeyCode.RightBracket))
        {
                //Debug.Log("43");
                move = new Vector3(15.29f, transform.position.y, transform.position.z);   // Disregard the player's x and z position.
                transform.position = Vector3.MoveTowards (transform.position, move, step);
                }
    }


    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Cube")
            return;
        else
        {
        GMA.currentHealth-=10;
        Debug.Log("Hit");
        if (invincinblecounter<=0)
        {
        invincinblecounter= invinciblelength;

        // For explosion effects
        Instantiate(explosion, transform.position, transform.rotation);

        playerrenderer.enabled = false;
        flashcounter=flashlength;
        Destroy(other.gameObject);
        }
        }
    }

    public void SetSpeed(float modifier)
    {
        speed =  15.0f + modifier;
    }
}
}
