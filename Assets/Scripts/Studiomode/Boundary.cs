using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Boundary : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}