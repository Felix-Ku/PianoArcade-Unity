using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliMotor : MonoBehaviour
{

    public float speed = 0.01f; 
    private Vector3 playerPOS;

    // Start is called before the first frame update
    void Start()
    {
        playerPOS = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

     
    void Update () 
    {
        transform.position = new Vector3 (Mathf.PingPong(Time.time, 20.0f) - 0.1f,transform.position.y,GameObject.FindGameObjectWithTag("Player").transform.position.z);
    }
}
