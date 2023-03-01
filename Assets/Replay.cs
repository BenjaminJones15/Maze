using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Replay : MonoBehaviour
{
    public GameObject Player;
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            Player.transform.position = Target.transform.position;

            //need to add all reset components
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
