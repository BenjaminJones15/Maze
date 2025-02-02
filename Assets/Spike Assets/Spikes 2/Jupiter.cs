using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jupiter : MonoBehaviour
{
    public static bool Check = false;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;

    public static GameObject Target;
    public static GameObject JupiterObject;

    public GameObject ShowTarget;
    public GameObject ShowJupiterObj;

    // Start is called before the first frame update
    void Start()
    {
        Target = ShowTarget;
        JupiterObject = ShowJupiterObj;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Jupiter"))
        {
            audioSource.PlayOneShot(clip, volume);
            Check = true;
            CheckDone.CheckComplete();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
