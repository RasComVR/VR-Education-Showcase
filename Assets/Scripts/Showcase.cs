using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showcase : MonoBehaviour
{
    public GameObject signArrow;
    public GameObject SCAudio;


    public void startShowcase(Animator animator)
    {
        SCAudio.SetActive(true);
        if(animator) animator.enabled = true;
    }


}
