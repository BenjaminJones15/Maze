using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venus : MonoBehaviour
{
    public static bool Check = false;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;

    public static GameObject Target;
    public static GameObject VenusObject;

    public GameObject ShowTarget;
    public GameObject ShowVenusObj;

    // Start is called before the first frame update
    void Start()
    {
        Target = ShowTarget;
        VenusObject = ShowVenusObj;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Venus"))
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
