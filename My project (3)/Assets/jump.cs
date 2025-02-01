using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class jump : MonoBehaviour
{
    private Rigidbody rb;
    private int upForce;
    private bool isGround;
    
    


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        upForce = 500;
        isGround = false;
        
        

        Vector3 tmp = GameObject.Find("player").transform.position;
    }

    void Update()
    {

        if (isGround == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(Jump());

            }
        }
        
        IEnumerator Jump()
        {
            
            rb.AddForce(new Vector3(0, upForce, 0));
            yield return new WaitForSeconds(1);
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
