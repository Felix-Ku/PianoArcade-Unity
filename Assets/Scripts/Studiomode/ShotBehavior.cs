using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShotBehavior : MonoBehaviour {


	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * speed;
	
	}

	void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "BackBoundary")
        {
            GameController.currentHealth -=10;
            Destroy(gameObject);
			return;
        }
    }
}
