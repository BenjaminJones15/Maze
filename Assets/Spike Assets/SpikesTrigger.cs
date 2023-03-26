using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;
    public Animator SpikesMove1;
    public Animator SpikesMove2;
    public GameObject Spikes1;
    public GameObject Spikes2;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        SpikesMove1.SetTrigger("Descend");
        SpikesMove2.SetTrigger("Descend");
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            audioSource.PlayOneShot(clip, volume);
            Spikes1.GetComponent<SkinnedMeshRenderer>().enabled = true;
            Spikes2.GetComponent<SkinnedMeshRenderer>().enabled = true;
            SpikesMove1.SetTrigger("Descend");
            SpikesMove2.SetTrigger("Descend");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
