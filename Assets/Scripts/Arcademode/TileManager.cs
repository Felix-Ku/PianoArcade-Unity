using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    public MidiPlayerA MidiPlayera;
    private string NotesString;

    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLength = 60.0f;
    private float safeZone = 50.0f; // 50m safezones to prevent early deletion of tiles
    private int amnTilesOnScreen =7;
    private int lastPrefabIndex = 0;


    private int tile;
    private int count=-1;

    // For deleting old tiles
    private List<GameObject> activeTiles;

    // Start is called before the first frame update
    void Start()
    {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;

        for(int i =0; i< amnTilesOnScreen; i++)
        {
            SpawnTile ();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z - safeZone >(spawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTile ();
            DeleteTile();
        }
    }

    void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        tile=MidiNoteArray();
        Debug.Log(tile);
        go = Instantiate (tilePrefabs [tile]) as GameObject;
        go.transform.SetParent (transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add (go);
        
    }

    void DeleteTile()
    {
        Destroy (activeTiles [0]);
        activeTiles.RemoveAt (0);
    }

    public int MidiNoteArray()
    {
    if (count < MidiPlayera.MidiNotes.Length && MidiPlayera.MidiNotes.Length!=0)
    {
        count=count+1;
        Debug.Log(MidiPlayera.MidiNotes.Length);
        
        NotesString=MidiPlayera.MidiNotes[count].Note;
        if (NotesString!="")
        {
            if (NotesString[0]=='C')
            {
                if (NotesString=="C5")
                    return 1;
                else if (NotesString=="C#5")
                    return 2;
                else if (NotesString=="C6")
                    return 3;
                else if (NotesString=="C#6")
                    return 4;
                else if (NotesString[1]=='#')
                    return 2;
                else
                {
                    return 1;
                }
            }
            else if (NotesString[0]=='D')
            {
                if (NotesString=="D5")
                    return 5;
                else if (NotesString=="D#5")
                    return 6;
                else if (NotesString=="D6")
                    return 7;
                else if (NotesString=="D#6")
                    return 8;
                else if (NotesString[1]=='#')
                    return 6;
                else
                {
                    return 5;
                }
            }
            else if (NotesString[0]=='E')
            {
                if (NotesString=="E5")
                    return 9;
                else if (NotesString=="E6")
                    return 10;
                else
                {
                    return 9;
                }
            }
            else if (NotesString[0]=='F')
            {
                if (NotesString=="F5")
                    return 11;
                else if (NotesString=="F#5")
                    return 12;
                else if (NotesString=="F6")
                    return 13;
                else if (NotesString=="F#6")
                    return 14;
                else if (NotesString[1]=='#')
                    return 12;
                else
                {
                    return 11;
                }
            }
            else if (NotesString[0]=='G')
            {
                if (NotesString=="G5")
                    return 15;
                else if (NotesString=="G#5")
                    return 16;
                else if (NotesString=="G6")
                    return 17;
                else if (NotesString[1]=='#')
                    return 16;
                else
                {
                    return 15;
                }
            }
            else if (NotesString[0]=='A')
            {
                if (NotesString=="A5")
                    return 18;
                else if (NotesString=="A#5")
                    return 19;
                else if (NotesString[1]=='#')
                    return 19;
                else
                {
                    return 18;
                }
            }
            else if (NotesString[0]=='B')
            {
                return 20;
            }
            else
            {
                return 0;
            }

           
        }
        else
            {
                return 0;
            }
        }
        else
        {
            return 0;
        }
    }

}
