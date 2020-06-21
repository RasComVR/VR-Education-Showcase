using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraControl : MonoBehaviour {

	Vector3 goalPos;
	float moveTime;

	IEnumerator movingCamera()
	{
		float startTime = Time.time;
		Vector3 origPos=Camera.main.transform.position;

		while (Time.time < startTime + moveTime)
		{
			float percTime=(Time.time-startTime)/moveTime;
			Camera.main.transform.position = Vector3.Lerp(origPos, goalPos, percTime);
			yield return null;
		}

		Camera.main.transform.position = goalPos;
	}


    public void moveCamera(Vector3 newPos, float time)
    {
    	goalPos=newPos;
    	moveTime=time;
    	StartCoroutine(movingCamera());
    }

    //public void moveCamera(Vector3 newPos, float time)
    //{
    //    print("moveCamera:  newPos=" + newPos + "  time=:" + time);
    //    db.cube(newPos);
    //    goalPos = newPos;
    //    moveTime = time;
    //    StartCoroutine(movingCamera());
    //}

    public void waypointClick()
    {
        Camera.main.GetComponent<CameraControl>().moveCamera(Vector3.zero, 3f);
        //Camera.main.GetComponent<CameraControl>().moveCamera(transform.position, 3f);
    }
}