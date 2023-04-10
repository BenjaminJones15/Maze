using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;
    public Animator SpikesMove;
    public GameObject Spikes;
    public Animator BirdMove;
    public GameObject Player;
    public GameObject Wall1;
    public GameObject Wall2 = null;
    public GameObject Wall3 = null;
    public Component[] list;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            audioSource.PlayOneShot(clip, volume);
            SpikesMove.SetTrigger("Descend");
            list = Spikes.GetComponentsInChildren<MeshRenderer>();
            {
                foreach (MeshRenderer spike in list)
                    spike.enabled = true;
            }

            Wall1.GetComponent<MeshRenderer>().enabled = true;
            if(Wall2 != null) {
                Wall2.GetComponent<MeshRenderer>().enabled = true;
                Wall3.GetComponent<MeshRenderer>().enabled = true;
            }
            if(BirdMove != null) {
                BirdMove.SetTrigger("Descend");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
