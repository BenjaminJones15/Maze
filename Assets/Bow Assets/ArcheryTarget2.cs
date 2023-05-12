//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Target that sends events when hit by an arrow
//
//=============================================================================

using UnityEngine;
using UnityEngine.Events;
using System.Collections;


//-------------------------------------------------------------------------
public class ArcheryTarget2 : MonoBehaviour
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

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;


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
            //onTakeDamage.Invoke();
            IsHit = true;
            audioSource.PlayOneShot(clip, volume);

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