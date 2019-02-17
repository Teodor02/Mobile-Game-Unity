using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public bool inAir = false;
    float Speed = 100;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (inAir == false)
            {
                transform.position += transform.up * Time.deltaTime * Speed;
                inAir = true;
            }
        }
    }
    void OnCollisionEnter(Collision hit)
        {
            if (hit.gameObject.tag == "Ground")
            {
                inAir = false;
            }
        }
}
