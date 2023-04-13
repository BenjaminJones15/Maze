using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBird : MonoBehaviour
{
    public GameObject PaperCrane;
    public Animator CraneAnim;
    public GameObject GrabCrane;
    public Vector3 temp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            PaperCrane.GetComponent<MeshRenderer>().enabled = false;
            PaperCrane.GetComponent<MeshCollider>().enabled = false;
            temp = PaperCrane.transform.position;
            GrabCrane.transform.position = temp;
            GrabCrane.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
