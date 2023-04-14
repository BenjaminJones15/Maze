using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    public Animator SpikesMove;
    public GameObject Button;
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            SpikesMove.speed = 0;
            Button.GetComponent<MeshRenderer>().enabled = false;
            Button.GetComponent<MeshCollider>().enabled = false;
            Text.GetComponent<MeshRenderer>().enabled = false;
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(5);
        SpikesMove.speed = 1;
        yield return new WaitForSecondsRealtime(10);
        Button.GetComponent<MeshRenderer>().enabled = true;
        Text.GetComponent<MeshRenderer>().enabled = true;
        Button.GetComponent<MeshCollider>().enabled = true;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
