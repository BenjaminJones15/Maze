using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawler : MonoBehaviour
{
    public GameObject Player;
    public Transform Target;
    public GameObject Teleport;
    public GameObject CrawlerObj;
    public Animator CrawlerMove;
    public GameObject Attack;
    public GameObject AttackView;
    public Animator CrawlerAttack;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;
    public Vector3 temp;

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
        Teleport.GetComponent<MeshRenderer>().enabled = false;
        CrawlerObj.GetComponent<SkinnedMeshRenderer>().enabled = false;
        temp = Player.transform.position;
        temp.x = temp.x + 1;
        Attack.transform.position = temp;
        AttackView.GetComponent<SkinnedMeshRenderer>().enabled = true;
        CrawlerAttack.SetTrigger("Attack");
        audioSource.PlayOneShot(clip, volume);
        yield return new WaitForSecondsRealtime(3);
        Player.transform.position = Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
