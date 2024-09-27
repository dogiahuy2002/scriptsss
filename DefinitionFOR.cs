using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefinitionFOR : MonoBehaviour
{
    
    void FixedUpdate ()
    {
        Debug.Log("Fixed Update Time :" + Time.deltaTime);
    }

    void Update()
    {
        Debug.Log("Update Time:" + Time.deltaTime);
        FixedUpdate();
    }

    
}
