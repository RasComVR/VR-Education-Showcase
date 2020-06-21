using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
    public float moveTime;
    private Vector3 newPosition;
    private Vector3 currentPosition;
    private float startTime;
    public GameObject cameraObject;


	// Use this for initialization
	void Start () {
        
    }

    IEnumerator MoveObject()
    {
        startTime = Time.time;
        while (Time.time < startTime + moveTime)
        {
            newPosition = new Vector3(gameObject.GetComponent<Transform>().position.x, gameObject.GetComponent<Transform>().position.y, gameObject.GetComponent<Transform>().position.z);
            cameraObject.transform.position = Vector3.Lerp(cameraObject.transform.position, newPosition, Time.deltaTime * moveTime);
            yield return null;
        }
    }

    public void moveCamera()
    {
        StartCoroutine(MoveObject());
    }

	// Update is called once per frame
	void Update () {
        
	}
}
