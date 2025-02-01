using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReloadText : MonoBehaviour
{
    public Text ReText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(rete());
        }


    }
    private IEnumerator rete()
    {
        yield return new WaitForSeconds(2f);
        ReText.text = "Reloading";
    }
}
    
