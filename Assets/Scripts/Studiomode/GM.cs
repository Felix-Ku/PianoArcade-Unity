using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MidiJack
{

public class GM : MonoBehaviour
{

    // Start is called before the first frame update
        public Color correct;
        public Color wrong;
        public Color originalW;
        public Color originalB;
        public Material Material;
        AudioSource audioSource;

        public GameObject shotPrefab;
        public GameObject[] meter;

    void Start()
    {
        Material = meter[0].GetComponent<MeshRenderer>().material;
        originalW=Material.color;
        Material = meter[1].GetComponent<MeshRenderer>().material;
        originalB=Material.color;
    }



    // Update is called once per frame
    void Update()
    {
        for (int i=0; i<=24; i++)
        {   
            
            if (meter[i].transform.rotation.x < 0.001f){
                Material = meter[i].GetComponent<MeshRenderer>().material;
                if (i==1||i==3||i==6||i==8||i==10||i==13||i==15||i==18||i==20||i==22)
                    Material.color=originalB;
                else
                    Material.color=originalW;
            }
            
            
        }
        switch (MidiSignalManager.MidiSignal)
        {
            case "30":
                meter[0].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[0].GetComponent<MeshRenderer>().material;
                audioSource = meter[0].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[0].transform.position.x,1,meter[0].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "31":
                meter[1].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[1].GetComponent<MeshRenderer>().material;
                audioSource = meter[1].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[1].transform.position.x,1,meter[1].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "32":
                meter[2].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[2].GetComponent<MeshRenderer>().material;
                audioSource = meter[2].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[2].transform.position.x,1,meter[2].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "33":
                meter[3].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[3].GetComponent<MeshRenderer>().material;
                audioSource = meter[3].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[3].transform.position.x,1,meter[3].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "34":
                meter[4].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[4].GetComponent<MeshRenderer>().material;
                audioSource = meter[4].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[4].transform.position.x,1,meter[4].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "35":
                meter[5].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[5].GetComponent<MeshRenderer>().material;
                audioSource = meter[5].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[5].transform.position.x,1,meter[5].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "36":
                meter[6].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[6].GetComponent<MeshRenderer>().material;
                audioSource = meter[6].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[6].transform.position.x,1,meter[6].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "37":
                meter[7].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[7].GetComponent<MeshRenderer>().material;
                audioSource = meter[7].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[7].transform.position.x,1,meter[7].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "38":
                meter[8].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[8].GetComponent<MeshRenderer>().material;
                audioSource = meter[8].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[8].transform.position.x,1,meter[8].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "39":
                meter[9].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[9].GetComponent<MeshRenderer>().material;
                audioSource = meter[9].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[9].transform.position.x,1,meter[9].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "3A":
                meter[10].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[10].GetComponent<MeshRenderer>().material;
                audioSource = meter[10].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[10].transform.position.x,1,meter[10].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "3B":
                meter[11].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[11].GetComponent<MeshRenderer>().material;
                audioSource = meter[11].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[11].transform.position.x,1,meter[11].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "3C":
                meter[12].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[12].GetComponent<MeshRenderer>().material;
                audioSource = meter[12].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[12].transform.position.x,1,meter[12].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "3D":
                meter[13].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[13].GetComponent<MeshRenderer>().material;
                audioSource = meter[13].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[13].transform.position.x,1,meter[13].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "3E":
                meter[14].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[14].GetComponent<MeshRenderer>().material;
                audioSource = meter[14].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[14].transform.position.x,1,meter[14].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "3F":
                meter[15].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[15].GetComponent<MeshRenderer>().material;
                audioSource = meter[15].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[15].transform.position.x,1,meter[15].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "40":
                meter[16].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[16].GetComponent<MeshRenderer>().material;
                audioSource = meter[16].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[16].transform.position.x,1,meter[16].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "41":
                meter[17].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[17].GetComponent<MeshRenderer>().material;
                audioSource = meter[17].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[17].transform.position.x,1,meter[17].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "42":
                meter[18].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[18].GetComponent<MeshRenderer>().material;
                audioSource = meter[18].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[18].transform.position.x,1,meter[18].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "43":
                meter[19].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[19].GetComponent<MeshRenderer>().material;
                audioSource = meter[19].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[19].transform.position.x,1,meter[19].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "44":
                meter[20].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[20].GetComponent<MeshRenderer>().material;
                audioSource = meter[20].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[20].transform.position.x,1,meter[20].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "45":
                meter[21].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[21].GetComponent<MeshRenderer>().material;
                audioSource = meter[21].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[21].transform.position.x,1,meter[21].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "46":
                meter[22].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[22].GetComponent<MeshRenderer>().material;
                audioSource = meter[22].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[22].transform.position.x,1,meter[22].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "47":
                meter[23].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[23].GetComponent<MeshRenderer>().material;
                audioSource = meter[23].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[23].transform.position.x,1,meter[23].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;
            case "48":
                meter[24].transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
                Material = meter[24].GetComponent<MeshRenderer>().material;
                audioSource = meter[24].GetComponent<AudioSource>();
                audioSource.Play();
                Instantiate(shotPrefab, new Vector3(meter[24].transform.position.x,1,meter[24].transform.position.z), Quaternion.Euler(0, 0, 0));
                Material.SetColor("_Color", correct);
                break;             
            default:
                break;
        }
    }
}

}
