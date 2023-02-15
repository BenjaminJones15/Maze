using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Easy : MonoBehaviour
{
    public GameObject Player;
    public Transform Target1;
    public Transform Target2;
    public Transform Target3;
    public Transform Target4;
    public Transform Target5;
    Random rnd = new Random();

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            Debug.Log("hard");
            int randint = rnd.Next(1, 6);        //teleports player to random area
            if (randint == 1)
            {
                Player.transform.position = Target1.transform.position;
            }
            else if (randint == 2)
            {
                Player.transform.position = Target2.transform.position;
            }
            else if (randint == 3)
            {
                Player.transform.position = Target3.transform.position;
            }
            else if (randint == 4)
            {
                Player.transform.position = Target4.transform.position;
            }
            else if (randint == 5)
            {
                Player.transform.position = Target5.transform.position;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
