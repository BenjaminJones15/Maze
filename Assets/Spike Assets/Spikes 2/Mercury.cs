using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercury : MonoBehaviour
{
    public static bool Check = false;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;

    public static GameObject Target;
    public static GameObject MercuryObject;

    public GameObject ShowTarget;
    public GameObject ShowMercuryObj;

    // Start is called before the first frame update
    void Start()
    {
        Target = ShowTarget;
        MercuryObject = ShowMercuryObj;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Mercury"))
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
