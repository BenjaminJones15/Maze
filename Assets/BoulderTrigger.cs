using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class BoulderTrigger : MonoBehaviour
{
    public GameObject Player;
    public GameObject Wall;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            Wall.GetComponent<MeshCollider>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
