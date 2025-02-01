using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAngle : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject player;
  

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        if (Mathf.Abs(mx) > 0.05f)
        {
            // ‰ñ“]²‚Íƒ[ƒ‹ƒhÀ•W‚ÌY²
            transform.RotateAround(player.transform.position, Vector3.up, mx);
        }
    }

}
