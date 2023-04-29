using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellContact1 : MonoBehaviour
{
    public static bool IsRung = false;
    public AudioSource ShowAudio;
    public static AudioSource audioSource;
    public AudioClip clip;
    public static float volume = 1f;
    public AudioClip ShowSuccess;
    public static AudioClip SuccessClip;

    public static GameObject Wall1;
    public GameObject ShowWall1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            Wall1 = ShowWall1;
            audioSource = ShowAudio;
            SuccessClip = ShowSuccess;
            audioSource.PlayOneShot(clip, volume);
            IsRung = true;
            CheckComplete();
        }
    }

    public static void CheckComplete()
    {
        if (BellContact1.IsRung == true && BellContact2.IsRung == true && BellContact3.IsRung == true)
        {
            BellContact1.audioSource.PlayOneShot(ArcheryTarget1.SuccessClip, ArcheryTarget1.volume);
            BellContact1.Wall1.GetComponent<MeshRenderer>().enabled = false;
            BellContact1.Wall1.GetComponent<TerrainCollider>().enabled = false;
            BellContact1.Wall1.GetComponent<BoxCollider>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
