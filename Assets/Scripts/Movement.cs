using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    public void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, yValue, zValue);
    }

}
