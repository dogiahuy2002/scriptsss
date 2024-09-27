using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision){
        //ẩn đối tượng khi có va chạm
        gameObject.SetActive(false);
    }
}
