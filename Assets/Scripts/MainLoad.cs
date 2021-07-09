using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainLoad : MonoBehaviour
{

    public float waittime = 12f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wait_for_intro());
    }

    // Update is called once per frame
    IEnumerator wait_for_intro()
    {
        yield return new WaitForSeconds(waittime);

        SceneManager.LoadScene("MainMenu");
    }
}
