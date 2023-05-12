using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correct : MonoBehaviour
{
    public GameObject Duck;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;
    public GameObject Target;
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Room1;
    public GameObject Room2;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Duck"))
        {
            Debug.Log("it worked");
            Duck.GetComponent<MeshRenderer>().enabled = false;
            audioSource.PlayOneShot(clip, volume);
            Wall1.GetComponent<MeshRenderer>().enabled = false;
            Wall1.GetComponent<TerrainCollider>().enabled = false;
            Wall1.GetComponent<BoxCollider>().enabled = false;
            Wall2.GetComponent<MeshRenderer>().enabled = false;
            Wall2.GetComponent<TerrainCollider>().enabled = false;
            Wall2.GetComponent<BoxCollider>().enabled = false;
            Wall3.GetComponent<MeshRenderer>().enabled = false;
            Wall3.GetComponent<TerrainCollider>().enabled = false;
            Wall3.GetComponent<BoxCollider>().enabled = false;
            Room1.SetActive(false);
            Room2.SetActive(false);
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(70);
        Duck.transform.position = Duck.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
