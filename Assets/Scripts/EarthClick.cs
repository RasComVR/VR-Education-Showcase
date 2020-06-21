using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthClick : MonoBehaviour
{
    public string AnimationToggle;
    public Animator StateMachine;
    public bool ClickEarth;

    // Use this for initialization
    void Start()
    {
        ClickEarth = false;
    }
    // Update is called once per frame
    void Update() { }

    public void clickEarth()
    {
        ClickEarth = true;
        StateMachine.SetBool(AnimationToggle, true);
    }

}
