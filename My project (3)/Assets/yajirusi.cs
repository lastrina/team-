using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    float speed = 5.0f;
    private int upForce;
    private bool isGround;
    


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGround = false;
        Vector3 tmp = GameObject.Find("player").transform.position;
        upForce = 500;
    }


    void Update()
    {
        // W�L�[�i�O���ړ��j
        if (Input.GetKey(KeyCode.W)&isGround)
        {
            rb.velocity = transform.forward * speed;
           

        }

        // S�L�[�i����ړ��j
        if (Input.GetKey(KeyCode.S)&isGround)
        {
            rb.velocity = -transform.forward * speed;
           
        }

        // D�L�[�i�E�ړ��j
        if (Input.GetKey(KeyCode.D) & isGround)
        {
            rb.velocity = transform.right * speed;
           


        }

        // A�L�[�i���ړ��j
        if (Input.GetKey(KeyCode.A) & isGround)
        {
            rb.velocity = -transform.right * speed;
           

        }

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            isGround = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            isGround = false;
        }
    }
}