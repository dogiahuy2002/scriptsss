using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalAxis : MonoBehaviour
{
    public float range = 2;
    //public Text textOutput ;
    void Update()
    {
    float h = Input.GetAxis("Horizontal");
    //float h = Input.GetAxis("Vertical");
    float xPos = h * range;
    //float yPos = h * range;
    transform.position = new Vector3(xPos, 2f, 0);
    //transform.position = new Vector3(2f, yPos,0 );
    Debug.Log("Value Returned: " + h.ToString("F2"));
    }
}
