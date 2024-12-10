using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CarrotCutting : MonoBehaviour
{
    public GameObject cuttedCarrot;
    public AudioClip collisionSound;

    // OnTriggerEnter is called when another collider makes contact with this object's collider (trigger).
    private void OnTriggerEnter(Collider other)
    {

        // Check if the colliding object has the tag "knife"
        if (other.gameObject.tag == "knife")
        {
            UnityEngine.Debug.Log("Knife has touched carrot"); //um

            // Check if cuttedCarrot is assigned to avoid null reference errors
            if (cuttedCarrot != null)
            {
                // play chop sound
                AudioSource.PlayClipAtPoint(collisionSound, transform.position, 1.0f)
            }

            // Deactivate this game object (the carrot before cutting) as the other appears
            gameObject.SetActive(false);
        }


    }


}
