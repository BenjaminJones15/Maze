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
    public Transform Target;


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
            Key.GetComponent<MeshRenderer>().enabled = false;
            Key.transform.position = Target.transform.position;
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(30);
        Lava1.GetComponent<MeshRenderer>().enabled = false;
        Lava2.GetComponent<MeshRenderer>().enabled = false;
        RockWall1.GetComponent<MeshRenderer>().enabled = false;
        RockWall2.GetComponent<MeshRenderer>().enabled = false;
        RockFloor.GetComponent<MeshRenderer>().enabled = false;
        Stone1.GetComponent<MeshRenderer>().enabled = false;
        Stone2.GetComponent<MeshRenderer>().enabled = false;
        Stone3.GetComponent<MeshRenderer>().enabled = false;
        Stone4.GetComponent<MeshRenderer>().enabled = false;
        Stone1.GetComponent<MeshCollider>().enabled = false;
        Stone2.GetComponent<MeshCollider>().enabled = false;
        Stone3.GetComponent<MeshCollider>().enabled = false;
        Stone4.GetComponent<MeshCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
