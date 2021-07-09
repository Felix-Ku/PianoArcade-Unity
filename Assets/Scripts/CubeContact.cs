using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeContact : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("HIT");
        audioSource.Play();
    }
}
