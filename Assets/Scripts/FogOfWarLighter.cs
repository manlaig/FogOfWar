using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOfWarLighter : MonoBehaviour
{
    [SerializeField] float radius = 75f;
    [SerializeField] GameObject fogPlane;
	
    // TODO: create an event when mouse 2 is clicked and update the fog plane in response to the event
    // right now it is updating even when the player is not moving, this can be improved
	void Update ()
    {
        fogPlane.GetComponent<FogPlane>().UpdateColor(transform, radius);
	}
}
