using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public static bool Check = false;
    public AudioSource ShowAudio;
    public AudioClip clip;
    public AudioClip ShowSuccess;
    public static float volume = 1f;

    public GameObject ShowTarget;
    public GameObject ShowSunObj;

    public GameObject ShowPlanetStands;
    public GameObject ShowPlanets;
    public GameObject ShowWall1;
    public GameObject ShowWall2;
    public GameObject ShowWall3;
    public GameObject ShowWall4;
    public GameObject ShowSpikes;
    public Animator ShowSpikeAnim;
    public Component[] ShowList;

    public static AudioSource audioSource;
    public static GameObject SunObject;
    public static GameObject Target;
    public static AudioClip SuccessClip;
    public static GameObject PlanetStands;
    public static GameObject Planets;
    public static GameObject Wall1;
    public static GameObject Wall2;
    public static GameObject Wall3;
    public static GameObject Wall4;
    public static GameObject Spikes;
    public static Animator SpikeAnim;
    public static Component[] list;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = ShowAudio;
        Target = ShowTarget;
        SunObject = ShowSunObj;
        SuccessClip = ShowSuccess;
        PlanetStands = ShowPlanetStands;
        Planets = ShowPlanets;
        Wall1 = ShowWall1;
        Wall2 = ShowWall2;
        Wall3 = ShowWall3;
        Wall4 = ShowWall4;
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
            StartCoroutine(waiter());       //move this to CheckDone? or call wait here, and then call this in a separate function?
        }
        
    }

    public IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(110);

        Planets.SetActive(true);
        PlanetStands.SetActive(true);

        Sun.SunObject.transform.position = Sun.Target.transform.position;
        Mercury.MercuryObject.transform.position = Mercury.Target.transform.position;
        Venus.VenusObject.transform.position = Venus.Target.transform.position;
        Earth.EarthObject.transform.position = Earth.Target.transform.position;
        Mars.MarsObject.transform.position = Mars.Target.transform.position;
        Jupiter.JupiterObject.transform.position = Jupiter.Target.transform.position;
        Saturn.SaturnObject.transform.position = Saturn.Target.transform.position;
        Uranus.UranusObject.transform.position = Uranus.Target.transform.position;
        Neptune.NeptuneObject.transform.position = Neptune.Target.transform.position;

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
