using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushButton : MonoBehaviour {

	public void startPlane()
    {
        Debug.Log("pushed");
    }

    void OnMouseClick()
    {
        Debug.Log("clickmethod called");
    }
}
