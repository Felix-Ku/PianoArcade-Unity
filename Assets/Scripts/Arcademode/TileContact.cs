using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileContact : MonoBehaviour
{

    public GameObject green;
    private GameObject playerObj = null;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        if (playerObj == null)
             playerObj = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(playerObj.transform.position.x);
            Debug.Log(playerObj.transform.position.y);
            Debug.Log(playerObj.transform.position.z);
        Debug.Log(green.transform.position.x);
        Debug.Log(green.transform.position.y);
        Debug.Log(green.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerObj.transform.position.z==green.transform.position.z)
        {
            
            Debug.Log("HIT");
            audioSource.Play();
        }
    }
}
