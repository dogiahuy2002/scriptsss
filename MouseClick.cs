using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDown ()
    {
    Debug.Log("ok");
    rb.AddForce(-transform.forward * 200f);
    rb.useGravity = true;
    }
}
