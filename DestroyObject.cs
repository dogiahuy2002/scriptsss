using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject orange;
    void Start()
    {
        Destroy(orange,5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
