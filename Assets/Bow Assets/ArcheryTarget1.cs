using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//-------------------------------------------------------------------------
public class ArcheryTarget1 : MonoBehaviour
{
    //public UnityEvent onTakeDamage;

    public bool onceOnly = true;
    public static bool IsHit = false;
    public Transform targetCenter;

    public GameObject ArcheryTarget;

    public Transform baseTransform;
    public Transform fallenDownTransform;
    public float fallTime = 0.5f;

    const float targetRadius = 0.25f;

    private bool targetEnabled = true;

    public AudioSource ShowAudio;
    public static AudioSource audioSource;
    public AudioClip clip;
    public static float volume = 1f;
    public AudioClip ShowSuccess;
    public static AudioClip SuccessClip;

    public static GameObject Wall1;
    public GameObject ShowWall1;


    //-------------------------------------------------
    private void ApplyDamage()
    {
        OnDamageTaken();
    }


    //-------------------------------------------------
    private void FireExposure()
    {
        OnDamageTaken();
    }


    //-------------------------------------------------
    private void OnDamageTaken()
    {
        if (targetEnabled)
        {
            Wall1 = ShowWall1;
            audioSource = ShowAudio;
            SuccessClip = ShowSuccess;
            audioSource.PlayOneShot(clip, volume);
            //onTakeDamage.Invoke();
            IsHit = true;

            if (onceOnly)
            {
                targetEnabled = false;
                ArcheryTarget.SetActive(false);
            }
            CheckComplete();
        }
    }

    public static void CheckComplete()
    {
        if (ArcheryTarget1.IsHit == true && ArcheryTarget2.IsHit == true && ArcheryTarget3.IsHit == true)
        {
            ArcheryTarget1.audioSource.PlayOneShot(ArcheryTarget1.SuccessClip, ArcheryTarget1.volume);
            ArcheryTarget1.Wall1.GetComponent<MeshRenderer>().enabled = false;
            ArcheryTarget1.Wall1.GetComponent<TerrainCollider>().enabled = false;
            ArcheryTarget1.Wall1.GetComponent<BoxCollider>().enabled = false;
        }
    }



}
