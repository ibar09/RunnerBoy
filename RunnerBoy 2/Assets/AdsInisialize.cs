using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsInisialize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Advertisements.Instance.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
