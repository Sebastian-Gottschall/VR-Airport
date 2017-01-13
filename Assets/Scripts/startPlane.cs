using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startPlane : MonoBehaviour {

    public void departThePlane(GameObject plane)
    {
        Debug.Log(plane.GetComponent<planeIdentifier>().identifier);
        plane.GetComponent<planeIdentifier>().allowed = true;
    }
}
