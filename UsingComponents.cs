using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingComponents : MonoBehaviour
{
    public GameObject otherGameObject;
    private AnotherScript another;
    private AnotherTwoScript anothertwo;
    private BoxCollider boxCol;
    void Awake ()
    {
    another = GetComponent<AnotherScript>();
    anothertwo = otherGameObject.GetComponent<AnotherTwoScript>();
    boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    void Start()
    {
    boxCol.size = new Vector3(3,3,3);
    Debug.Log("The player's score is " + another.playerScore);
    Debug.Log("The player has died " + anothertwo.numberOfPlayerDeaths + " times");
    } 

}
