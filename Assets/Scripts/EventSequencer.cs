using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monofinity
{

    [System.Serializable]
    public struct SeqEvent
    {
        public float onTime;
        public float offTime;
        public GameObject obj;
    }



    public class EventSequencer : MonoBehaviour
    {


        public List<SeqEvent> events;

        float startTime;


        void Start()
        {
            startTime = Time.time;
        }


        void Update()
        {
            float timeElapsed = Time.time - startTime;

            foreach (SeqEvent e in events)
            {
                if (!e.obj.activeInHierarchy && timeElapsed >= e.onTime) e.obj.SetActive(true);
                else if (e.obj.activeInHierarchy && e.offTime > 0 && timeElapsed >= e.offTime)
                {
                    e.obj.SetActive(false);
                    events.Remove(e);
                    break;
                }
            }
        }

    }

}
