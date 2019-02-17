using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    
    private bool Jumping = false;
    private float Speed = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jumping = true;
        }
        if (Jumping == true)
        {
            transform.position += Vector3.up * Speed * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Ground")
        {
            Jumping = false;
        }
    }
}
