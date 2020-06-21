using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour {
   
    SignTransport transportBool;
    public GameObject ScriptReference;
  
    private void Start()
    {
        transportBool = ScriptReference.GetComponent<SignTransport>();
    }

   // IEnumerator animationToggle()
   //{
   //     gameObject.GetComponent<Animator>().enabled = true;
   //     yield return new WaitForSeconds(4);
   //     gameObject.GetComponent<Animator>().enabled = false;
   // }

    // Update is called once per frame
    void Update()
    {

        if (transportBool.transportCheck == true)
        {
            //        StartCoroutine(animationToggle());
            gameObject.GetComponent<Animator>().enabled = true;
        }
    }

}
