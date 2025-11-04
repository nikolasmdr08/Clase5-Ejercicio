using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CicloDeVida : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        Debug.Log("Update");
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
