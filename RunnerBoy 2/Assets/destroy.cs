using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

     void Start()
    {

        StartCoroutine(Destroy());

    }

    IEnumerator Destroy()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1.72f);
        Destroy(gameObject);

        //After we have waited 5 seconds print the time again.
        Debug.Log("throw" + Time.time);
    }
}
