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
    public GameObject Lock1;
    public GameObject Lock2;
    public GameObject Lock3;
    public GameObject Lava1;
    public GameObject Lava2;
    public GameObject RockWall1;
    public GameObject RockWall2;
    public GameObject RockFloor;
    public GameObject Key;
    public GameObject Stone1;
    public GameObject Stone2;
    public GameObject Stone3;
    public GameObject Stone4;
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
            Wall1.GetComponent<TerrainCollider>().enabled = true;
            Wall1.GetComponent<BoxCollider>().enabled = true;
            if(Wall2 != null) {
                Wall2.GetComponent<MeshRenderer>().enabled = true;
                Wall3.GetComponent<MeshRenderer>().enabled = true;
                Wall2.GetComponent<TerrainCollider>().enabled = true;
                Wall3.GetComponent<TerrainCollider>().enabled = true;
                Wall2.GetComponent<BoxCollider>().enabled = true;
                Wall3.GetComponent<BoxCollider>().enabled = true;
            }
            if(BirdMove != null) {
                BirdMove.SetTrigger("Descend");
            }
            if(Lock1 != null){
                Lock1.GetComponent<MeshRenderer>().enabled = true;
                Lock2.GetComponent<MeshRenderer>().enabled = true;
                Lock3.GetComponent<MeshRenderer>().enabled = true;
                Lava1.GetComponent<MeshRenderer>().enabled = true;
                Lava2.GetComponent<MeshRenderer>().enabled = true;
                RockWall1.GetComponent<MeshRenderer>().enabled = true;
                RockWall2.GetComponent<MeshRenderer>().enabled = true;
                RockFloor.GetComponent<MeshRenderer>().enabled = true;
                Key.GetComponent<MeshRenderer>().enabled = true;
                Stone1.GetComponent<MeshRenderer>().enabled = true;
                Stone2.GetComponent<MeshRenderer>().enabled = true;
                Stone3.GetComponent<MeshRenderer>().enabled = true;
                Stone4.GetComponent<MeshRenderer>().enabled = true;
                Stone1.GetComponent<MeshCollider>().enabled = true;
                Stone2.GetComponent<MeshCollider>().enabled = true;
                Stone3.GetComponent<MeshCollider>().enabled = true;
                Stone4.GetComponent<MeshCollider>().enabled = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
