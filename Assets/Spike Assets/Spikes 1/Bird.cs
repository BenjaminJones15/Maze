using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;
    public GameObject Wall;
    public GameObject MyBird;
    public GameObject Spikes;
    public GameObject Target;
    public Component[] list;
    public Animator SpikeAnim;

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
            Wall.GetComponent<TerrainCollider>().enabled = false;
            Wall.GetComponent<BoxCollider>().enabled = false;
            SpikeAnim.ResetTrigger("Descend");
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(70);
        MyBird.transform.position = Target.transform.position;
        list = Spikes.GetComponentsInChildren<MeshRenderer>();
        {
            foreach (MeshRenderer spike in list)
                spike.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
