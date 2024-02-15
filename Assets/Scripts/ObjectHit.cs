using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            gameObject.tag = "Hit";
        }
    }
}
