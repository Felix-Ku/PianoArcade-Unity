using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadblock : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Hit");

        Destroy(gameObject);
        
    }
}
