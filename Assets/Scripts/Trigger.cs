using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name.Equals ("Player"))
        {
            rb.isKinematic = false;
        }
    }

}
