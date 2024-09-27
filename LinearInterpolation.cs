using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{

    private Light myLight;
    void Start()
    {
    myLight = GetComponent<Light>();
        float result = Mathf.Lerp (3f, 5f, 0.5f);
        Vector3 from = new Vector3 (1f, 2f, 3f);
        Vector3 to = new Vector3 (5f, 6f, 7f);
        Vector3 rs = Vector3.Lerp (from, to, 0.75f);
    }

    
    // Update is called once per frame
    void Update()
    {
        myLight.intensity = Mathf.Lerp(myLight.intensity, 8f, 0.5f);
        myLight.intensity = Mathf.Lerp(myLight.intensity, 8f, 0.5f * Time.deltaTime);

    }
}
