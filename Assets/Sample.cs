using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        throw new InvalidOperationException("Logfile cannot be read-only");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
