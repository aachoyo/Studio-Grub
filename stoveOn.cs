using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoveOn : MonoBehaviour
{
    public GameObject cube;
    public GameObject matchstick;
    public GameObject fire;
    public GameObject displayButton;

    // Method triggered when another collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the cube is the colliding object w/ matchstick
        if (other.gameObject == cube)
        {
            // Activate fire
            fire.SetActive(true);

            if (displayButton != null)
            {
                displayButton.SetActive(true);
            }
        }
    }
}
