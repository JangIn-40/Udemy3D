using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    [SerializeField] float dropTime = 3f;

    Rigidbody myrigidbody;
    MeshRenderer meshRenderer;

    void Awake()
    {
        myrigidbody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Start()
    {
        myrigidbody.useGravity = false;
        meshRenderer.enabled = false;
    }

    void Update()
    {
        DropObject();
    }

    void DropObject()
    {
        if(Time.time > dropTime)
        {
            meshRenderer.enabled = true;
            myrigidbody.useGravity = true;
            
        }
    }
}
