using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public static bool Check = false;
    public AudioSource ShowAudio;
    public static AudioSource audioSource;
    public AudioClip clip;
    public static float volume = 1f;

    public GameObject ShowTarget;
    public GameObject ShowSunView;
    public GameObject ShowSunObj;
    public static GameObject Target;
    public static GameObject SunView;
    public static GameObject SunObject;

    public AudioClip ShowSuccess;
    public GameObject ShowPlanetStands;
    public GameObject ShowWall1;
    public GameObject ShowWall2;
    public GameObject ShowWall3;
    public GameObject ShowSpikes;
    public Animator ShowSpikeAnim;
    public Component[] ShowList;

    public static AudioClip SuccessClip;
    public static GameObject PlanetStands;
    public static GameObject Wall1;
    public static GameObject Wall2;
    public static GameObject Wall3;
    public static GameObject Spikes;
    public static Animator SpikeAnim;
    public static Component[] list;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = ShowAudio;
        Target = ShowTarget;
        SunView = ShowSunView;
        SunObject = ShowSunObj;
        SuccessClip = ShowSuccess;
        PlanetStands = ShowPlanetStands;
        Wall1 = ShowWall1;
        Wall2 = ShowWall2;
        Wall3 = ShowWall3;
        Spikes = ShowSpikes;
        SpikeAnim = ShowSpikeAnim;
        list = ShowList;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Sun"))
        {
            audioSource.PlayOneShot(clip, volume);
            Check = true;
            CheckDone.CheckComplete();
            StartCoroutine(waiter());
        }
        
    }

    public IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(70);
        Sun.SunObject.transform.position = Sun.Target.transform.position;
        Mercury.MercuryObject.transform.position = Mercury.Target.transform.position;
        Venus.VenusObject.transform.position = Venus.Target.transform.position;
        Earth.EarthObject.transform.position = Earth.Target.transform.position;
        Mars.MarsObject.transform.position = Mars.Target.transform.position;
        Jupiter.JupiterObject.transform.position = Jupiter.Target.transform.position;
        Saturn.SaturnObject.transform.position = Saturn.Target.transform.position;
        Uranus.UranusObject.transform.position = Uranus.Target.transform.position;
        Neptune.NeptuneObject.transform.position = Neptune.Target.transform.position;

        Sun.SunView.GetComponent<MeshRenderer>().enabled = false;
        Mercury.MercuryView.GetComponent<MeshRenderer>().enabled = false;
        Venus.VenusView.GetComponent<MeshRenderer>().enabled = false;
        Earth.EarthView.GetComponent<MeshRenderer>().enabled = false;
        Mars.MarsView.GetComponent<MeshRenderer>().enabled = false;
        Jupiter.JupiterView.GetComponent<MeshRenderer>().enabled = false;
        Saturn.SaturnView.GetComponent<MeshRenderer>().enabled = false;
        Saturn.RingsView.GetComponent<MeshRenderer>().enabled = false;
        Uranus.UranusView.GetComponent<MeshRenderer>().enabled = false;
        Neptune.NeptuneView.GetComponent<MeshRenderer>().enabled = false;

        Sun.SunObject.GetComponent<SphereCollider>().enabled = false;
        Mercury.MercuryObject.GetComponent<SphereCollider>().enabled = false;
        Venus.VenusObject.GetComponent<SphereCollider>().enabled = false;
        Earth.EarthObject.GetComponent<SphereCollider>().enabled = false;
        Mars.MarsObject.GetComponent<SphereCollider>().enabled = false;
        Jupiter.JupiterObject.GetComponent<SphereCollider>().enabled = false;
        Saturn.SaturnObject.GetComponent<SphereCollider>().enabled = false;
        Uranus.UranusObject.GetComponent<SphereCollider>().enabled = false;
        Neptune.NeptuneObject.GetComponent<SphereCollider>().enabled = false;

        Sun.list = Sun.PlanetStands.GetComponentsInChildren<MeshRenderer>();
        {
            foreach (MeshRenderer stand in Sun.list)
                stand.enabled = false;
        }


        Sun.list = Sun.Spikes.GetComponentsInChildren<MeshRenderer>();
        {
            foreach (MeshRenderer spike in Sun.list)
                spike.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
