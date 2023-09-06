using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;

    bool isJump = false;
    public float jumpForce = 5.0f;

    
    void Start()
    {
     rb = GetComponent<Rigidbody>();
    }
    public float speed = 5.0f;

    
    void Update()
    {
        //Movimientos:
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");     

        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        //Salto:
        isJump = Input.GetButtonDown("Jump");

        if (isJump)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
        
    }
}