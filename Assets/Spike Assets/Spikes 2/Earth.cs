using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public static bool Check = false;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;

    public static GameObject Target;
    public static GameObject EarthView;
    public static GameObject EarthObject;

    public GameObject ShowTarget;
    public GameObject ShowEarthView;
    public GameObject ShowEarthObj;

    // Start is called before the first frame update
    void Start()
    {
        Target = ShowTarget;
        EarthView = ShowEarthView;
        EarthObject = ShowEarthObj;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Earth"))
        {
            audioSource.PlayOneShot(clip, volume);
            Check = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
