using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crackingEgg : MonoBehaviour
{
    public GameObject plate;
    public GameObject egg;
    public GameObject crackedegg;
    public GameObject displayButton;

    // Method triggered when another collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the plate is the colliding object
        if (other.gameObject == plate)
        {
            // Deactivate egg
            egg.SetActive(false);

            // Activate cracked egg
            crackedegg.SetActive(true);

            if (displayButton != null)
            {
                displayButton.SetActive(true);
            }

        }
    }
}