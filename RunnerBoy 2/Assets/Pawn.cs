using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    public GameObject UI;

        

    void OnTriggerEnter(Collider Obj)
    {
        if (Obj.tag == "Player")
        {
            UI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider Obj)
    {
        if (Obj.tag == "Player")
        {
            UI.SetActive(false);
        }
    }
}
