using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonView : MonoBehaviour {

    public GameObject MoonObject;
    EarthClick earthClick;
    public bool check;
    public GameObject ScriptReference; //This is the gameObject that I am trying to get a variable from

    // Use this for initialization
    void Start () {
        check = false;
    }

    public void moonRotation()
    {
        gameObject.GetComponent<Animator>().enabled = true;
        
    }

    // Update is called once per frame
    void Update () {
        earthClick = ScriptReference.GetComponent<EarthClick>();
        if (earthClick.ClickEarth == true)
        {
            check = true;
            moonRotation();
        }

    }
}
