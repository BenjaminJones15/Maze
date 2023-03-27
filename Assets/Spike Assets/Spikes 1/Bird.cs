using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;
    public Animator SpikeAnim1;
    public Animator SpikeAnim2;
    public GameObject Wall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("bird"))
        {
            audioSource.PlayOneShot(clip, volume);
            Wall.GetComponent<MeshRenderer>().enabled = false;
            //SpikeAnim1.SetTrigger("Wrong");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
