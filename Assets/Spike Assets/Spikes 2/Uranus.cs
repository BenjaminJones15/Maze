using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uranus : MonoBehaviour
{
    public static bool Check = false;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;

    public static GameObject Target;
    public static GameObject UranusObject;

    public GameObject ShowTarget;
    public GameObject ShowUranusObj;

    // Start is called before the first frame update
    void Start()
    {
        Target = ShowTarget;
        UranusObject = ShowUranusObj;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Uranus"))
        {
            audioSource.PlayOneShot(clip, volume);
            Check = true;
            CheckDone.CheckComplete();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
