using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public GameObject Player;
    public Transform Target;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            audioSource.PlayOneShot(clip, volume);
            Player.transform.position = Target.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
