using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{
    
    void Awake()
    {
        UnityEngine.Debug.Log("Awake function");    
    }

    void Start()
    {
        UnityEngine.Debug.Log("Start function");
    }

    
    void Update()
    {
        UnityEngine.Debug.Log("Update function");
    }
}
