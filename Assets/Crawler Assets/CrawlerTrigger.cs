using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlerTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;
    public Animator CrawlerMove;
    public GameObject Crawler;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            audioSource.PlayOneShot(clip, volume);
            Crawler.GetComponent<SkinnedMeshRenderer>().enabled = true;
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(1);
        CrawlerMove.SetTrigger("Move");
        CrawlerMove.SetTrigger("Chase");
        yield return new WaitForSecondsRealtime(5);
        //Crawler.GetComponent<SkinnedMeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
