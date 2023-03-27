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
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        CrawlerMove["Move 1"].speed = 0;
        CrawlerMove.SetTrigger("Attack");
        audioSource.PlayOneShot(clip, volume);
        yield return new WaitForSecondsRealtime(3);
        //Player.transform.position = Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
