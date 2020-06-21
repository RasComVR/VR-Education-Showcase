using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointPosition : MonoBehaviour
{
    public float transitionTime;
    private Vector3 heightAdd = new Vector3 (0, 1.886f, 0);

    public void waypointClick()
    {
        Camera.main.GetComponent<CameraControl>().moveCamera(transform.position + heightAdd, transitionTime);
            gameObject.SetActive(false);
    }
}
