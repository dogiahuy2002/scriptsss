using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeModifier : MonoBehaviour
{
    public int alpha = 5;
    private int beta = 5;
    private int gamma = 5;
    
    void Example(int pens, int crayons)
    {
    int answer;
    answer = pens*crayons*alpha;
    Debug.Log(answer);
    }
    // Start is called before the first frame update
    void Start()
    {
         Example(beta,gamma);
         alpha =79;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
