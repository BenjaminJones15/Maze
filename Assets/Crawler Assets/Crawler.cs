using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawler : MonoBehaviour
{
    public GameObject Player;
    public Transform Target;
    public Animator CrawlerMove;
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
            audioSource.PlayOneShot(clip, volume);
            CrawlerMove.SetTrigger("Attack");            
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        CrawlerMove.SetTrigger("Attack");
        yield return new WaitForSecondsRealtime(4);
        Player.transform.position = Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
