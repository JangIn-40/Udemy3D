using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;


    void Start()
    {
        PrintInstruction();
    }

    void Update()
    {
        PlayerMove();
    }

    void PrintInstruction()
    {
        Debug.Log("Weolcom to the game");
        Debug.Log("This game is mud");
        Debug.Log("I hope you enjoy this world!");
    }

    void PlayerMove()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
    }

}
