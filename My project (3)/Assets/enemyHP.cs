using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class enemyHP : MonoBehaviour
{
    public float hp;
    public float GunDamage;
    private bool atari;
    public Text nokori;
    // Start is called before the first frame update
    void Start()
    {
        atari = false;
        transform.localScale = new Vector3(-1,1,-1);
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
            transform.position = new Vector3(50,-50,50);
            StartCoroutine(rete());
        }
        nokori.text = hp.ToString();
        transform.LookAt(Camera.main.transform);
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
    private IEnumerator rete()
    {
        yield return new WaitForSeconds(2f);
        transform.position = new Vector3(50,1,50);
        hp = 100;
    }

}
