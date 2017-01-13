using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeIdentifier : MonoBehaviour {

    public GameObject plane;
    public string identifier;
    public float flightHeight;
    public string target;
    public bool allowed = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (allowed)
        {
            Debug.Log("departure of plane: " + identifier + " allowed");
        }
	}

    public void allowDeparture()
    {
        allowed = true;
    }
}
