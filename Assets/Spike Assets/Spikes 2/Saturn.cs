using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saturn : MonoBehaviour
{
    public static bool Check = false;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;

    public static GameObject Target;
    public static GameObject SaturnView;
    public static GameObject RingsView;
    public static GameObject SaturnObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Saturn"))
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
