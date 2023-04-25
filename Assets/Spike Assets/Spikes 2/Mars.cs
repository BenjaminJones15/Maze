using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mars : MonoBehaviour
{
    public static bool Check = false;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;

    public static GameObject Target;
    public static GameObject MarsView;
    public static GameObject MarsObject;

    public GameObject ShowTarget;
    public GameObject ShowMarsView;
    public GameObject ShowMarsObj;

    // Start is called before the first frame update
    void Start()
    {
        Target = ShowTarget;
        MarsView = ShowMarsView;
        MarsObject = ShowMarsObj;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Mars"))
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
