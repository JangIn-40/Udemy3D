using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int Score = 0;

    void OnCollisionEnter(Collision other) 
    {

        if(!other.gameObject.CompareTag("Hit"))
        {
            Score++;
            Debug.Log($"you've bumped int a thing this {Score} times");
        }

    }
}
