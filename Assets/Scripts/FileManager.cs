using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Runtime.InteropServices;



public class FileManager : MonoBehaviour
{
    string path;

    public void OpenExplorer()
    {
        #if UNITY_EDITOR
        path= EditorUtility.OpenFilePanel("","","mid");
        #endif
    }
}

