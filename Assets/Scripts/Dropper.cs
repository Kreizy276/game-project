using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    Rigidbody rb;
    MeshRenderer mr;
    [SerializeField] float timeToWait = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();

        rb.useGravity = false;
        mr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            rb.useGravity = true;
            mr.enabled = true;
            Debug.Log("3 seconds have passed");
        }
    }
}
