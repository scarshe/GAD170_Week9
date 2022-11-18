using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider yeet)
    {
        yeet.gameObject.GetComponent<Rigidbody>().AddForce(yeet.gameObject.transform.up * 1000);
    }
}
