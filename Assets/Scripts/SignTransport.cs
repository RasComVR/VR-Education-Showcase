using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignTransport : MonoBehaviour {
    public bool transportCheck;
	// Use this for initialization
	void Start () {
        transportCheck = false;
	}
	
    public void TransportMethod ()
    {
        transportCheck = true;
    }
}
