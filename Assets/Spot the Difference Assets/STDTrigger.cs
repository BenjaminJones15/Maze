using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STDTrigger : MonoBehaviour
{
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Room1;
    public GameObject Room2;
    public GameObject Trigger;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            Debug.Log("it worked");
            Wall1.GetComponent<MeshRenderer>().enabled = true;
            Wall1.GetComponent<TerrainCollider>().enabled = true;
            Wall1.GetComponent<BoxCollider>().enabled = true;
            Wall2.GetComponent<MeshRenderer>().enabled = true;
            Wall2.GetComponent<TerrainCollider>().enabled = true;
            Wall2.GetComponent<BoxCollider>().enabled = true;
            Wall3.GetComponent<MeshRenderer>().enabled = true;
            Wall3.GetComponent<TerrainCollider>().enabled = true;
            Wall3.GetComponent<BoxCollider>().enabled = true;
            Room1.SetActive(true);
            Room2.SetActive(true);
            Trigger.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
