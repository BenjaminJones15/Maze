using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowTrigger : MonoBehaviour
{
    public GameObject Wall1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            Wall1.GetComponent<MeshRenderer>().enabled = true;
            Wall1.GetComponent<TerrainCollider>().enabled = true;
            Wall1.GetComponent<BoxCollider>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
