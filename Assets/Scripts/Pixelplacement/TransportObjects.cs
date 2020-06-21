using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransportObjects : MonoBehaviour {

    private float transitionTime = 2f;

    void Start() { Camera.main.GetComponent<CameraControl>().moveCamera(transform.position, transitionTime); }

}
