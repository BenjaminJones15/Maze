using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
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
            //need sound effects
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
