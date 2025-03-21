using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;


public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletprefab;
    public float shotSpeed;
    public int shotCount = 30;
    private float shotInterval;
    private bool touched;

    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Mouse0)) 
       {
            shotInterval += 1;
            if (shotInterval%5 == 0 & shotCount > 0 )
            {
                shotCount -= 1;
                GameObject bullet = (GameObject)Instantiate(bulletprefab,transform.position,Quaternion.Euler
                    (transform.parent.eulerAngles.x,transform.parent.eulerAngles.y,0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);
                Destroy(bullet, 3.0f);
               
            }

       }
       else if (Input.GetKeyDown(KeyCode.R)) 
       {
            StartCoroutine(Reload());


       }
        
    }
    private IEnumerator Reload()
    {

        yield return new WaitForSeconds(2f);
        shotCount = 30;

    }
   
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "tama(Clone)")
        {
            touched = true;


        }
    }

}
