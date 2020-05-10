using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class JohnPickup : MonoBehaviour
{
    public Text lemonNumberText;
    /// <summary>
    /// The number of lemons.
    /// </summary>
    int m_Lemons;

    /// <summary>
    /// The collectible layer.
    /// </summary>
    int m_CollectibleLayer;

    private void Start()
    {
        // Initialise the number of lemons to 0
        m_Lemons = 0;

        // Initialise the layer using the name we gave it
        m_CollectibleLayer = LayerMask.NameToLayer("Collectible");
    }

    // This is called when John enters ANY Trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // If John touched an object in the Collectible layer
        if (other.gameObject.layer == m_CollectibleLayer)
        {
            // Get the LemonPickupable component on the game object we touched
            var pickupable = other.gameObject.GetComponent<LemonPickupable>();
            if (pickupable != null)
            {
                // Call the PickupObject method
                pickupable.PickupObject();
                // Increase the number of lemons John has
                m_Lemons++;
                lemonNumberText.text = m_Lemons.ToString("00");
            }
        }
    }
}