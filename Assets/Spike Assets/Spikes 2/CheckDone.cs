using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDone : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void CheckComplete()
    {
        if (Sun.Check = true && Mercury.Check == true && Venus.Check == true && Earth.Check == true && Mars.Check == true && Jupiter.Check == true && Saturn.Check == true && Uranus.Check == true && Neptune.Check == true)
        {
            Sun.audioSource.PlayOneShot(Sun.SuccessClip, Sun.volume);
            Sun.Wall1.GetComponent<MeshRenderer>().enabled = false;
            Sun.Wall1.GetComponent<TerrainCollider>().enabled = false;
            Sun.Wall1.GetComponent<BoxCollider>().enabled = false;
            Sun.Wall2.GetComponent<MeshRenderer>().enabled = false;
            Sun.Wall2.GetComponent<TerrainCollider>().enabled = false;
            Sun.Wall2.GetComponent<BoxCollider>().enabled = false;
            Sun.Wall3.GetComponent<MeshRenderer>().enabled = false;
            Sun.Wall3.GetComponent<TerrainCollider>().enabled = false;
            Sun.Wall3.GetComponent<BoxCollider>().enabled = false;
            Sun.SpikeAnim.ResetTrigger("Descend");

            
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
