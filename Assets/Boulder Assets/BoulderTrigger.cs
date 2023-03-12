using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class BoulderTrigger : MonoBehaviour
{
    public GameObject Player;
    public GameObject Wall;
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
            Wall.GetComponent<MeshCollider>().enabled = false;
            audioSource.PlayOneShot(clip, volume);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
