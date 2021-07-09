using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pianokeys : MonoBehaviour
{
    AudioSource audioSource;
    //public MusicTone MusicTone;
    public int Octave = 3;

    public float ResetPlayTime = 0.5f;
    private float currentResetPlayTime = 0;
    
    public float MaxZRotation = 360.0f;

    private Vector3 initialPosition;
    
    public float ZRotationResetVelocity = -6;

    public float MouseClickDownRotation = 600;
    public float MouseClickSmoothTime = 0.5f;
    private Vector3 smoothVelocity = Vector3.zero;


	public GameObject shotPrefab;

	// Use this for initialization
	void Start () {
        currentResetPlayTime = ResetPlayTime;
        initialPosition = transform.position;
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
    {

        // For smooth transformation
        if (transform.rotation.eulerAngles.x > 0.1f)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(Time.deltaTime * ZRotationResetVelocity,0, 0));
            transform.GetComponent<Rigidbody>().angularDrag = 0;
            transform.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }

        if (transform.rotation.eulerAngles.x > MaxZRotation)
        {
            transform.rotation = Quaternion.Euler(MaxZRotation, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            transform.GetComponent<Rigidbody>().angularDrag = 0;
            transform.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
       
        if (transform.rotation.eulerAngles.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            transform.GetComponent<Rigidbody>().angularDrag = 0;
            transform.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }

        if (currentResetPlayTime < ResetPlayTime)
            currentResetPlayTime += Time.deltaTime;

        transform.position = initialPosition;
        transform.GetComponent<Rigidbody>().velocity = Vector3.zero;               
	}
       
    public void OnMouseDown()
    {
            audioSource.Play();
            transform.rotation = Quaternion.Euler (-5f, 0f, 0f);
        
			GameObject go = GameObject.Instantiate(shotPrefab, new Vector3(transform.position.x,1,transform.position.z), Quaternion.Euler(0, 0, 0)) as GameObject;
	
    }

}

