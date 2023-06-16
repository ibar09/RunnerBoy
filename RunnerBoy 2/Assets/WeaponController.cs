using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject Pans;
    public GameObject ThisObject;
    public GameObject ThisObject1;
    public GameObject ThisObject2;
    public GameObject ThisObject3;
    public GameObject ThisObject4;
    public GameObject ThisObject5;
    public GameObject ThisObject6;
    public GameObject ThisObject7;
    public GameObject ThisObject8;

    public GameObject Pawner;



    void Update()
    {
        if (Pawner.activeSelf == true)
        {
            ThisObject.SetActive(false);
            ThisObject1.SetActive(false);
            ThisObject2.SetActive(false);
            ThisObject3.SetActive(false);
            ThisObject4.SetActive(false);
            ThisObject5.SetActive(false);
            ThisObject6.SetActive(false);
            ThisObject7.SetActive(false);
            ThisObject8.SetActive(false);
        }
        if (Pawner.activeSelf == false)
        {
            ThisObject.SetActive(true);
            ThisObject1.SetActive(true);
            ThisObject2.SetActive(true);
            ThisObject3.SetActive(true);
            ThisObject4.SetActive(true);
            ThisObject5.SetActive(true);
            ThisObject6.SetActive(true);
            ThisObject7.SetActive(true);
            ThisObject8.SetActive(true);
        }
    }



    public void ThrowPans()
    {

        StartCoroutine(Pan());

    }

    public void pickupitem()
    {

        StartCoroutine(pickup());

    }


    IEnumerator Pan()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1.72f);
        Pans.SetActive(false);

        //After we have waited 5 seconds print the time again.
        Debug.Log("throw" + Time.time);
    }


    IEnumerator pickup()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1.72f);
        Pans.SetActive(true);

        //After we have waited 5 seconds print the time again.
        Debug.Log("throw" + Time.time);
    }



}
