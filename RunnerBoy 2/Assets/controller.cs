using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public GameObject Cb;



    void OnTriggerEnter(Collider Obj)
    {
        if (Obj.tag == "Enemy")
        {
            Cb.SetActive(true);
        }
    }

    void OnTriggerExit(Collider Obj)
    {
        if (Obj.tag == "Enemy")
        {
            Cb.SetActive(false);
        }
    }
}
