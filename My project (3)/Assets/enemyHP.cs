using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHP : MonoBehaviour
{
    public float hp;
    public float GunDamage;
    private bool atari;
    // Start is called before the first frame update
    void Start()
    {
        atari = false;
    }

    // 
    void Update()
    {
        if (atari==true)
        {
            hp = hp - GunDamage;
            
            

        }
        if (hp <= 0) 
        {
            Destroy(gameObject);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "tama(Clone)")
        {
            atari = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "tama(Clone)")
        {
            atari = false;


        }
    }
}
