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
    public GameObject Wall1;
    public GameObject Wall2 = null;
    public GameObject Wall3 = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            audioSource.PlayOneShot(clip, volume);
            Spikes1.GetComponent<MeshRenderer>().enabled = true;
            Spikes2.GetComponent<MeshRenderer>().enabled = true;
            SpikesMove1.SetTrigger("Descend");
            SpikesMove2.SetTrigger("Descend");
            Wall1.GetComponent<MeshRenderer>().enabled = true;
            if(Wall2 != null) {
                Wall2.GetComponent<MeshRenderer>().enabled = true;
                Wall3.GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
