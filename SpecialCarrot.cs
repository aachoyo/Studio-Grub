using UnityEngine;

public class SpecialCarrot : MonoBehaviour
{
    public GameObject display;
    
    // OnTriggerEnter is called when another collider makes contact with this object's collider (trigger).
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "knife"
        if (other.gameObject.tag == "knife")
        {
            UnityEngine.Debug.Log("Knife has touched carrot"); //um

            if (display != null)
            {
                display.SetActive(true);
            }

            // Deactivate this game object (the carrot before cutting) as the other appears
            gameObject.SetActive(false);
        }
    }
}
