using UnityEngine;

public class openCabinet : MonoBehaviour
{
    public GameObject displayButton;   // Reference to the UI element (e.g., panel, text, image)
    public string playerTag = "Player";  // Tag assigned to player (or specific tag)

    // Method triggered when another collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the player's tag
        if (other.CompareTag(playerTag))
        {
            // Show the UI element
            if (displayButton != null)
            {
                displayButton.SetActive(true);
            }
        }
    }

    // Method triggered when another collider exits the trigger collider
    private void OnTriggerExit(Collider other)
    {
        // Check if the colliding object has the player's tag
        if (other.CompareTag(playerTag))
        {
            // Hide the UI element when the player exits the area
            if (displayButton != null)
            {
                displayButton.SetActive(false);
            }
        }
    }
}
