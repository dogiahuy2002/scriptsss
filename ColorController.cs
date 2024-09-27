using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
   // Array of materials to change the wall color
    public Material[] wallMaterial;
    
    // Renderer component of the wall
    private Renderer rend;

    void Start()
    {
        // Assigns the component's renderer instance
        rend = GetComponent<Renderer>();
        // Make sure the renderer is enabled
        rend.enabled = true;
    }

    // Called when the ball collides with the wall
    private void OnCollisionEnter(Collision col)
    {
        // Check if the colliding object is the player ball
        if (col.gameObject.name == "player-ball")
        {
            // Change the wall material to the first material in the array
            rend.sharedMaterial = wallMaterial[0]; 
        }
    }

    // Called when the ball moves away from the wall
    private void OnCollisionExit(Collision col)
    {
        // Check if the object leaving collision is the player ball
        if (col.gameObject.name == "player-ball")
        {
            // Change the wall material to the second material in the array
            
            rend.sharedMaterial = wallMaterial[1];
        }
    }
}
