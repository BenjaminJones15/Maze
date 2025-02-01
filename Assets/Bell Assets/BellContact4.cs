using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellContact4 : MonoBehaviour
{
    public static bool IsRung = false;

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            audioSource.PlayOneShot(clip, volume);
            IsRung = true;
            BellContact1.CheckComplete();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
