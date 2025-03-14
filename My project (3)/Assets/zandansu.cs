using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class zandansu : MonoBehaviour
{
    
    public Text TextZandan;
    private float shotInterval;
    private int Zandan = 30;
   


    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        TextZandan.text = "Magazine:" + Zandan.ToString();
        if (Input.GetKey(KeyCode.Mouse0))
        {
            shotInterval += 1;
            if (shotInterval % 5 == 0 & Zandan > 0)
            {
                Zandan -= 1;
                

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
        Zandan = 30;
        
    }
    
    
}
