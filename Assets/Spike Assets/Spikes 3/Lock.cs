using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;
    public GameObject Wall;
    public GameObject Lock1;
    public GameObject Lock2;
    public GameObject Lock3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("key"))
        {
            audioSource.PlayOneShot(clip, volume);
            Wall.GetComponent<MeshRenderer>().enabled = false;
            Wall.GetComponent<TerrainCollider>().enabled = false;
            Wall.GetComponent<BoxCollider>().enabled = false;
            Lock1.GetComponent<MeshRenderer>().enabled = false;
            Lock2.GetComponent<MeshRenderer>().enabled = false;
            Lock3.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
