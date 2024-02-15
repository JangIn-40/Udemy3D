using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float amountRotation = 10f;

    Transform myTransform;

    void Awake()
    {
        myTransform = GetComponent<Transform>();
    }

    void Update()
    {
        // transform.rotation = Quaternion.Euler(0, Time.time * amountRotation, 0);
        // 어려운방법쓴거네 ㅋㅋㅋ;
        transform.Rotate(0, amountRotation, 0);
    }
}
