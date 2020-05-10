using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickupable : MonoBehaviour
{
   
    /// <summary>
    /// Classes that extends from this
    /// can specify their logic here.
    /// </summary>
    protected abstract IEnumerator Pickup();

    /// <summary>
    /// This function can be called from
    /// the player to pickup this object.
    /// </summary>
    public void PickupObject()
    {
        Pickup();
        Destroy(gameObject);
    }
}
