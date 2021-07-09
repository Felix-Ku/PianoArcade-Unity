using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

namespace MidiJack
{

public class MidiSignalManager : MonoBehaviour
{
    public static string MidiSignal;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    #region Editor Support

    #if UNITY_EDITOR
    // Update is called once per frame
    void FixedUpdate()
    {
        MidiSignal="";
        foreach (var message in MidiDriver.Instance.History)
        MidiSignal = (message.ToString().Substring(8,2));
        MidiDriver.Instance.History.Clear();
    }
    #endif

    #endregion
}

}