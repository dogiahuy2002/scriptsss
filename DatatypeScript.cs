using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Reference type variable
        Transform tran=transform;
        tran.position=new Vector3(0, 2, 0);
    }
}
